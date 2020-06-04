using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace UniversalCalculator
{
    public partial class MainForm : Form
    {
        static Ctrl ctrl;
        public MainForm()
        {
            ctrl = new Ctrl();
            
            InitializeComponent();

            textBox.SelectionStart = 1;
            baseUpDown.Value = trackBar.Value;
        }

        private void Interface_KeyDown(object sender, KeyEventArgs e)
        {
            if (baseUpDown.Focused)
                return;
            
            var numBase = ctrl.GetNumberBase();
            var mode = ctrl.GetMode();
            
            switch (e.KeyData)
            {
                case Keys key when (key >= Keys.D0 && key <= Keys.D9 && numBase > e.KeyValue - 48):
                    textBox.Text = ctrl.ExecuteEditorCommand(Ctrl.EditorCommand.AddDigit, (e.KeyValue - 48).ToString());
                    return;
                case Keys key when (key >= Keys.NumPad0 && key <= Keys.NumPad9 && numBase > e.KeyValue - 96):
                    textBox.Text = ctrl.ExecuteEditorCommand(Ctrl.EditorCommand.AddDigit, (e.KeyValue - 96).ToString());
                    return;
                case Keys key when (key >= Keys.A && key <= Keys.F && numBase > e.KeyValue - 55):
                    textBox.Text = ctrl.ExecuteEditorCommand(Ctrl.EditorCommand.AddDigit, key.ToString());
                    return;
                case Keys.Back:
                case Keys.Delete:
                    textBox.Text = ctrl.ExecuteEditorCommand(Ctrl.EditorCommand.DeleteChar);
                    return;
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                case Keys.Decimal:
                    textBox.Text = ctrl.ExecuteEditorCommand(Ctrl.EditorCommand.AddPoint);
                    return;
                case Keys.Add:
                    textBox.Text = ctrl.ExecuteCalculatorCommand(Ctrl.CalculatorCommand.Add);
                    return;
                case Keys.Subtract:
                    textBox.Text = ctrl.ExecuteCalculatorCommand(Ctrl.CalculatorCommand.Subtract);
                    return;
                case Keys.Multiply:
                    textBox.Text = ctrl.ExecuteCalculatorCommand(Ctrl.CalculatorCommand.Multiply);
                    return;
                case Keys.Divide:
                    textBox.Text = ctrl.ExecuteCalculatorCommand(Ctrl.CalculatorCommand.Divide);
                    return;
                case Keys.OemPipe | Keys.Shift:
                case Keys.OemQuestion:
                case Keys.I:
                    if (mode == Processor.Mode.Fractional)
                        textBox.Text = ctrl.ExecuteEditorCommand(Ctrl.EditorCommand.AddDelim);
                    else if (mode == Processor.Mode.Complex)
                        textBox.Text = ctrl.ExecuteEditorCommand(Ctrl.EditorCommand.AddDelim, "+");
                    return;
                case Keys.Oemplus:
                case Keys.Enter:
                    textBox.Text = ctrl.ExecuteCalculatorCommand(Ctrl.CalculatorCommand.Calculate);
                    return;
                default:
                    return;
            }
        }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void base_ValueChanged(object sender, EventArgs e)
        {
            if (sender is TrackBar t)
                baseUpDown.Value = t.Value;
            else if (sender is NumericUpDown n)
                trackBar.Value = (int) n.Value;
            textBox.Text = ctrl.ChangeNumberBase(trackBar.Value);
            EnableNumberButtons();
        }

        private void EnableNumberButtons()
        {
            var numBase = ctrl.GetNumberBase();

            if (numBase >= 10)
            {
                var symbolRegex = new Regex(@"^[A-F]$");
                foreach (Button b in tableLayoutPanel2.Controls.OfType<Button>())
                {
                    if (symbolRegex.IsMatch(b.Text))
                        b.Enabled = numBase > b.Text[0] - 55;
                }

                if (numBase > 10)
                    return;
            }

            var numberRegex = new Regex(@"[2-9]");
            foreach (Button b in tableLayoutPanel.Controls.OfType<Button>())
            {
                if (numberRegex.IsMatch(b.Text))
                    b.Enabled = numBase > b.Text[0] - 48;
            }
        }
        
        private void charBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = ctrl.ExecuteEditorCommand(Ctrl.EditorCommand.AddDigit, (sender as Button)?.Text);
        }

        private void editorOperationBtn_Click(object sender, EventArgs e)
        {
            var cmd = (Ctrl.EditorCommand)Enum.Parse(typeof(Ctrl.EditorCommand), (sender as Button)?.AccessibleName);
            textBox.Text = ctrl.ExecuteEditorCommand(cmd, (sender as Button)?.AccessibleDescription);
        }
        
        private void calculatorOperationBtn_Click(object sender, EventArgs e)
        {
            var cmd = (Ctrl.CalculatorCommand) Enum.Parse(typeof(Ctrl.CalculatorCommand), (sender as Button)?.AccessibleName);
            textBox.Text = ctrl.ExecuteCalculatorCommand(cmd);
        }

        private void memoryOperationBtn_Click(object sender, EventArgs e)
        {
            var cmd = (Ctrl.MemoryCommand) Enum.Parse(typeof(Ctrl.MemoryCommand), (sender as Button)?.AccessibleName);
            textBox.Text = ctrl.ExecuteMemoryCommand(cmd);

            MCBtn.Enabled = MRBtn.Enabled = MPlusBtn.Enabled = ctrl.GetMemoryState();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Info().ShowDialog();
        }

        private void pNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Enabled = true;
            fracDelim.Enabled = addIm.Enabled = subIm.Enabled = false;
            SetNumberBase(10);
            EnableNumberButtons();
            textBox.Text = ctrl.ChangeMode(Processor.Mode.PNumber).numberString;
            MCBtn.Enabled = MRBtn.Enabled = MPlusBtn.Enabled = ctrl.GetMemoryState();
        }

        private void fractionalNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fracDelim.Enabled = true;
            tableLayoutPanel2.Enabled = addIm.Enabled = subIm.Enabled = false;
            SetNumberBase(10);
            EnableNumberButtons();
            textBox.Text = ctrl.ChangeMode(Processor.Mode.Fractional).numberString;
            MCBtn.Enabled = MRBtn.Enabled = MPlusBtn.Enabled = ctrl.GetMemoryState();
        }

        private void complexNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addIm.Enabled = subIm.Enabled = true;
            tableLayoutPanel2.Enabled = fracDelim.Enabled = false;
            SetNumberBase(10);
            EnableNumberButtons();
            textBox.Text = ctrl.ChangeMode(Processor.Mode.Complex).numberString;
            MCBtn.Enabled = MRBtn.Enabled = MPlusBtn.Enabled = ctrl.GetMemoryState();
        }

        private void SetNumberBase(int numBase)
        {
            ctrl.ChangeNumberBase(numBase);
            trackBar.Value = numBase;
            baseUpDown.Value = numBase;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox)?.Text != "0")
            {
                clearBtn.Text = "CE";
                clearBtn.AccessibleName = "Clear";
            }
            else
            {
                clearBtn.Text = "AC";
                clearBtn.AccessibleName = "Reset";
            }
        }
    }
}