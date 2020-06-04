using System.ComponentModel;

namespace UniversalCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox = new System.Windows.Forms.TextBox();
            this.MCBtn = new System.Windows.Forms.Button();
            this.MRBtn = new System.Windows.Forms.Button();
            this.MPlusBtn = new System.Windows.Forms.Button();
            this.MSBtn = new System.Windows.Forms.Button();
            this.inverseBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.DBtn = new System.Windows.Forms.Button();
            this.EBtn = new System.Windows.Forms.Button();
            this.FBtn = new System.Windows.Forms.Button();
            this.backspaceBtn = new System.Windows.Forms.Button();
            this.ABtn = new System.Windows.Forms.Button();
            this.BBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.sevenBtn = new System.Windows.Forms.Button();
            this.eightBtn = new System.Windows.Forms.Button();
            this.nineBtn = new System.Windows.Forms.Button();
            this.multBtn = new System.Windows.Forms.Button();
            this.fourBtn = new System.Windows.Forms.Button();
            this.fiveBtn = new System.Windows.Forms.Button();
            this.sixBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.oneBtn = new System.Windows.Forms.Button();
            this.twoBtn = new System.Windows.Forms.Button();
            this.threeBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.signBtn = new System.Windows.Forms.Button();
            this.zeroBtn = new System.Windows.Forms.Button();
            this.pointBtn = new System.Windows.Forms.Button();
            this.equalBtn = new System.Windows.Forms.Button();
            this.CBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fractionalNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complexNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.baseUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.subIm = new System.Windows.Forms.Button();
            this.fracDelim = new System.Windows.Forms.Button();
            this.addIm = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseUpDown)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(2, 2);
            this.textBox.Margin = new System.Windows.Forms.Padding(2);
            this.textBox.MaxLength = 9;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(264, 30);
            this.textBox.TabIndex = 38;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // MCBtn
            // 
            this.MCBtn.AccessibleName = "Clear";
            this.MCBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MCBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MCBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MCBtn.Enabled = false;
            this.MCBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MCBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MCBtn.Location = new System.Drawing.Point(2, 2);
            this.MCBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MCBtn.Name = "MCBtn";
            this.MCBtn.Size = new System.Drawing.Size(64, 41);
            this.MCBtn.TabIndex = 2;
            this.MCBtn.Text = "MC";
            this.MCBtn.UseVisualStyleBackColor = false;
            this.MCBtn.Click += new System.EventHandler(this.memoryOperationBtn_Click);
            // 
            // MRBtn
            // 
            this.MRBtn.AccessibleName = "Read";
            this.MRBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MRBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MRBtn.Enabled = false;
            this.MRBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MRBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MRBtn.Location = new System.Drawing.Point(70, 2);
            this.MRBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MRBtn.Name = "MRBtn";
            this.MRBtn.Size = new System.Drawing.Size(64, 41);
            this.MRBtn.TabIndex = 3;
            this.MRBtn.Text = "MR";
            this.MRBtn.UseVisualStyleBackColor = false;
            this.MRBtn.Click += new System.EventHandler(this.memoryOperationBtn_Click);
            // 
            // MPlusBtn
            // 
            this.MPlusBtn.AccessibleName = "Add";
            this.MPlusBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MPlusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MPlusBtn.Enabled = false;
            this.MPlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MPlusBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MPlusBtn.Location = new System.Drawing.Point(138, 2);
            this.MPlusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MPlusBtn.Name = "MPlusBtn";
            this.MPlusBtn.Size = new System.Drawing.Size(64, 41);
            this.MPlusBtn.TabIndex = 4;
            this.MPlusBtn.Text = "M+";
            this.MPlusBtn.UseVisualStyleBackColor = false;
            this.MPlusBtn.Click += new System.EventHandler(this.memoryOperationBtn_Click);
            // 
            // MSBtn
            // 
            this.MSBtn.AccessibleName = "Write";
            this.MSBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MSBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MSBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSBtn.Location = new System.Drawing.Point(206, 2);
            this.MSBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MSBtn.Name = "MSBtn";
            this.MSBtn.Size = new System.Drawing.Size(64, 41);
            this.MSBtn.TabIndex = 5;
            this.MSBtn.Text = "MS";
            this.MSBtn.UseVisualStyleBackColor = false;
            this.MSBtn.Click += new System.EventHandler(this.memoryOperationBtn_Click);
            // 
            // inverseBtn
            // 
            this.inverseBtn.AccessibleName = "Inverse";
            this.inverseBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.inverseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inverseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inverseBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inverseBtn.Location = new System.Drawing.Point(2, 47);
            this.inverseBtn.Margin = new System.Windows.Forms.Padding(2);
            this.inverseBtn.Name = "inverseBtn";
            this.inverseBtn.Size = new System.Drawing.Size(64, 41);
            this.inverseBtn.TabIndex = 6;
            this.inverseBtn.Text = "1/x";
            this.inverseBtn.UseVisualStyleBackColor = false;
            this.inverseBtn.Click += new System.EventHandler(this.calculatorOperationBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.AccessibleName = "Square";
            this.squareBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.squareBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squareBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squareBtn.Location = new System.Drawing.Point(70, 47);
            this.squareBtn.Margin = new System.Windows.Forms.Padding(2);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(64, 41);
            this.squareBtn.TabIndex = 7;
            this.squareBtn.Text = "x²";
            this.squareBtn.UseVisualStyleBackColor = false;
            this.squareBtn.Click += new System.EventHandler(this.calculatorOperationBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AccessibleName = "Reset";
            this.clearBtn.BackColor = System.Drawing.Color.Thistle;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(138, 47);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(64, 41);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "AC";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.editorOperationBtn_Click);
            // 
            // DBtn
            // 
            this.DBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DBtn.BackColor = System.Drawing.Color.Lavender;
            this.DBtn.Enabled = false;
            this.DBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DBtn.Location = new System.Drawing.Point(69, 2);
            this.DBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DBtn.Name = "DBtn";
            this.DBtn.Size = new System.Drawing.Size(64, 41);
            this.DBtn.TabIndex = 31;
            this.DBtn.Text = "D";
            this.DBtn.UseVisualStyleBackColor = false;
            this.DBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // EBtn
            // 
            this.EBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EBtn.BackColor = System.Drawing.Color.Lavender;
            this.EBtn.Enabled = false;
            this.EBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EBtn.Location = new System.Drawing.Point(137, 2);
            this.EBtn.Margin = new System.Windows.Forms.Padding(2);
            this.EBtn.Name = "EBtn";
            this.EBtn.Size = new System.Drawing.Size(64, 41);
            this.EBtn.TabIndex = 32;
            this.EBtn.Text = "E";
            this.EBtn.UseVisualStyleBackColor = false;
            this.EBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // FBtn
            // 
            this.FBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FBtn.BackColor = System.Drawing.Color.Lavender;
            this.FBtn.Enabled = false;
            this.FBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FBtn.Location = new System.Drawing.Point(205, 2);
            this.FBtn.Margin = new System.Windows.Forms.Padding(2);
            this.FBtn.Name = "FBtn";
            this.FBtn.Size = new System.Drawing.Size(64, 41);
            this.FBtn.TabIndex = 33;
            this.FBtn.Text = "F";
            this.FBtn.UseVisualStyleBackColor = false;
            this.FBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // backspaceBtn
            // 
            this.backspaceBtn.AccessibleName = "DeleteChar";
            this.backspaceBtn.BackColor = System.Drawing.Color.Thistle;
            this.backspaceBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backspaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspaceBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backspaceBtn.Location = new System.Drawing.Point(206, 47);
            this.backspaceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backspaceBtn.Name = "backspaceBtn";
            this.backspaceBtn.Size = new System.Drawing.Size(64, 41);
            this.backspaceBtn.TabIndex = 10;
            this.backspaceBtn.Text = "⌫";
            this.backspaceBtn.UseVisualStyleBackColor = false;
            this.backspaceBtn.Click += new System.EventHandler(this.editorOperationBtn_Click);
            // 
            // ABtn
            // 
            this.ABtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ABtn.BackColor = System.Drawing.Color.Lavender;
            this.ABtn.Enabled = false;
            this.ABtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ABtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ABtn.Location = new System.Drawing.Point(69, 47);
            this.ABtn.Margin = new System.Windows.Forms.Padding(2);
            this.ABtn.Name = "ABtn";
            this.ABtn.Size = new System.Drawing.Size(64, 41);
            this.ABtn.TabIndex = 34;
            this.ABtn.Text = "A";
            this.ABtn.UseVisualStyleBackColor = false;
            this.ABtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // BBtn
            // 
            this.BBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BBtn.BackColor = System.Drawing.Color.Lavender;
            this.BBtn.Enabled = false;
            this.BBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBtn.Location = new System.Drawing.Point(137, 47);
            this.BBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BBtn.Name = "BBtn";
            this.BBtn.Size = new System.Drawing.Size(64, 41);
            this.BBtn.TabIndex = 35;
            this.BBtn.Text = "B";
            this.BBtn.UseVisualStyleBackColor = false;
            this.BBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.AccessibleName = "Divide";
            this.divideBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.divideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideBtn.Font = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divideBtn.Location = new System.Drawing.Point(206, 92);
            this.divideBtn.Margin = new System.Windows.Forms.Padding(2);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(64, 41);
            this.divideBtn.TabIndex = 14;
            this.divideBtn.Text = "÷";
            this.divideBtn.UseVisualStyleBackColor = false;
            this.divideBtn.Click += new System.EventHandler(this.calculatorOperationBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.BackColor = System.Drawing.Color.Lavender;
            this.sevenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sevenBtn.Location = new System.Drawing.Point(2, 92);
            this.sevenBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(64, 41);
            this.sevenBtn.TabIndex = 11;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = false;
            this.sevenBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.BackColor = System.Drawing.Color.Lavender;
            this.eightBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eightBtn.Location = new System.Drawing.Point(70, 92);
            this.eightBtn.Margin = new System.Windows.Forms.Padding(2);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(64, 41);
            this.eightBtn.TabIndex = 12;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = false;
            this.eightBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.BackColor = System.Drawing.Color.Lavender;
            this.nineBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nineBtn.Location = new System.Drawing.Point(138, 92);
            this.nineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(64, 41);
            this.nineBtn.TabIndex = 13;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = false;
            this.nineBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // multBtn
            // 
            this.multBtn.AccessibleName = "Multiply";
            this.multBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.multBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multBtn.Location = new System.Drawing.Point(206, 137);
            this.multBtn.Margin = new System.Windows.Forms.Padding(2);
            this.multBtn.Name = "multBtn";
            this.multBtn.Size = new System.Drawing.Size(64, 41);
            this.multBtn.TabIndex = 18;
            this.multBtn.Text = "×";
            this.multBtn.UseVisualStyleBackColor = false;
            this.multBtn.Click += new System.EventHandler(this.calculatorOperationBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.BackColor = System.Drawing.Color.Lavender;
            this.fourBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourBtn.Location = new System.Drawing.Point(2, 137);
            this.fourBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(64, 41);
            this.fourBtn.TabIndex = 15;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = false;
            this.fourBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.BackColor = System.Drawing.Color.Lavender;
            this.fiveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fiveBtn.Location = new System.Drawing.Point(70, 137);
            this.fiveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(64, 41);
            this.fiveBtn.TabIndex = 16;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = false;
            this.fiveBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.BackColor = System.Drawing.Color.Lavender;
            this.sixBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixBtn.Location = new System.Drawing.Point(138, 137);
            this.sixBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(64, 41);
            this.sixBtn.TabIndex = 17;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = false;
            this.sixBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.AccessibleName = "Subtract";
            this.minusBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.minusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.Font = new System.Drawing.Font("Segoe UI", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusBtn.Location = new System.Drawing.Point(206, 182);
            this.minusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(64, 41);
            this.minusBtn.TabIndex = 22;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = false;
            this.minusBtn.Click += new System.EventHandler(this.calculatorOperationBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.BackColor = System.Drawing.Color.Lavender;
            this.oneBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneBtn.Location = new System.Drawing.Point(2, 182);
            this.oneBtn.Margin = new System.Windows.Forms.Padding(2);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(64, 41);
            this.oneBtn.TabIndex = 19;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = false;
            this.oneBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.BackColor = System.Drawing.Color.Lavender;
            this.twoBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.twoBtn.Location = new System.Drawing.Point(70, 182);
            this.twoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(64, 41);
            this.twoBtn.TabIndex = 20;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = false;
            this.twoBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.BackColor = System.Drawing.Color.Lavender;
            this.threeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.threeBtn.Location = new System.Drawing.Point(138, 182);
            this.threeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(64, 41);
            this.threeBtn.TabIndex = 21;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = false;
            this.threeBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.AccessibleName = "Add";
            this.plusBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.plusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(206, 227);
            this.plusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(64, 41);
            this.plusBtn.TabIndex = 26;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = false;
            this.plusBtn.Click += new System.EventHandler(this.calculatorOperationBtn_Click);
            // 
            // signBtn
            // 
            this.signBtn.AccessibleName = "ChangeSign";
            this.signBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.signBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signBtn.Location = new System.Drawing.Point(2, 227);
            this.signBtn.Margin = new System.Windows.Forms.Padding(2);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(64, 41);
            this.signBtn.TabIndex = 23;
            this.signBtn.Text = "+/-";
            this.signBtn.UseVisualStyleBackColor = false;
            this.signBtn.Click += new System.EventHandler(this.editorOperationBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.BackColor = System.Drawing.Color.Lavender;
            this.zeroBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zeroBtn.Location = new System.Drawing.Point(70, 227);
            this.zeroBtn.Margin = new System.Windows.Forms.Padding(2);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(64, 41);
            this.zeroBtn.TabIndex = 24;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = false;
            this.zeroBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // pointBtn
            // 
            this.pointBtn.AccessibleName = "AddPoint";
            this.pointBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pointBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointBtn.Location = new System.Drawing.Point(138, 227);
            this.pointBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pointBtn.Name = "pointBtn";
            this.pointBtn.Size = new System.Drawing.Size(64, 41);
            this.pointBtn.TabIndex = 25;
            this.pointBtn.Text = ".";
            this.pointBtn.UseVisualStyleBackColor = false;
            this.pointBtn.Click += new System.EventHandler(this.editorOperationBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.AccessibleName = "Calculate";
            this.equalBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.equalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equalBtn.Location = new System.Drawing.Point(206, 272);
            this.equalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(64, 41);
            this.equalBtn.TabIndex = 30;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = false;
            this.equalBtn.Click += new System.EventHandler(this.calculatorOperationBtn_Click);
            // 
            // CBtn
            // 
            this.CBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CBtn.BackColor = System.Drawing.Color.Lavender;
            this.CBtn.Enabled = false;
            this.CBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBtn.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBtn.Location = new System.Drawing.Point(205, 47);
            this.CBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(64, 41);
            this.CBtn.TabIndex = 36;
            this.CBtn.Text = "C";
            this.CBtn.UseVisualStyleBackColor = false;
            this.CBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNumberToolStripMenuItem,
            this.fractionalNumberToolStripMenuItem,
            this.complexNumberToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.settingsToolStripMenuItem.Text = "settings";
            // 
            // pNumberToolStripMenuItem
            // 
            this.pNumberToolStripMenuItem.Name = "pNumberToolStripMenuItem";
            this.pNumberToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.pNumberToolStripMenuItem.Text = "P-Number";
            this.pNumberToolStripMenuItem.Click += new System.EventHandler(this.pNumberToolStripMenuItem_Click);
            // 
            // fractionalNumberToolStripMenuItem
            // 
            this.fractionalNumberToolStripMenuItem.Name = "fractionalNumberToolStripMenuItem";
            this.fractionalNumberToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.fractionalNumberToolStripMenuItem.Text = "Fractional Number";
            this.fractionalNumberToolStripMenuItem.Click += new System.EventHandler(this.fractionalNumberToolStripMenuItem_Click);
            // 
            // complexNumberToolStripMenuItem
            // 
            this.complexNumberToolStripMenuItem.Name = "complexNumberToolStripMenuItem";
            this.complexNumberToolStripMenuItem.Size = new System.Drawing.Size(199, 24);
            this.complexNumberToolStripMenuItem.Text = "Complex Number";
            this.complexNumberToolStripMenuItem.Click += new System.EventHandler(this.complexNumberToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Base:";
            // 
            // baseUpDown
            // 
            this.baseUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.baseUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.854546F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baseUpDown.Location = new System.Drawing.Point(11, 47);
            this.baseUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.baseUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.baseUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.baseUpDown.Name = "baseUpDown";
            this.baseUpDown.Size = new System.Drawing.Size(45, 21);
            this.baseUpDown.TabIndex = 38;
            this.baseUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.baseUpDown.ValueChanged += new System.EventHandler(this.base_ValueChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel.Controls.Add(this.subIm, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.fracDelim, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.addIm, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.squareBtn, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.inverseBtn, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.MSBtn, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.MPlusBtn, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.MRBtn, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.MCBtn, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.clearBtn, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.backspaceBtn, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.divideBtn, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.multBtn, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.minusBtn, 3, 4);
            this.tableLayoutPanel.Controls.Add(this.plusBtn, 3, 5);
            this.tableLayoutPanel.Controls.Add(this.nineBtn, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.sixBtn, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.threeBtn, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.eightBtn, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.fiveBtn, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.twoBtn, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.zeroBtn, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.sevenBtn, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.fourBtn, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.oneBtn, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.signBtn, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.pointBtn, 2, 5);
            this.tableLayoutPanel.Controls.Add(this.equalBtn, 3, 6);
            this.tableLayoutPanel.Location = new System.Drawing.Point(5, 64);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(270, 315);
            this.tableLayoutPanel.TabIndex = 38;
            // 
            // subIm
            // 
            this.subIm.AccessibleDescription = "-";
            this.subIm.AccessibleName = "AddDelim";
            this.subIm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.subIm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subIm.Enabled = false;
            this.subIm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subIm.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subIm.Location = new System.Drawing.Point(138, 272);
            this.subIm.Margin = new System.Windows.Forms.Padding(2);
            this.subIm.Name = "subIm";
            this.subIm.Size = new System.Drawing.Size(64, 41);
            this.subIm.TabIndex = 29;
            this.subIm.Text = "-i";
            this.subIm.UseVisualStyleBackColor = false;
            this.subIm.Click += new System.EventHandler(this.editorOperationBtn_Click);
            // 
            // fracDelim
            // 
            this.fracDelim.AccessibleName = "AddDelim";
            this.fracDelim.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fracDelim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fracDelim.Enabled = false;
            this.fracDelim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fracDelim.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fracDelim.Location = new System.Drawing.Point(2, 272);
            this.fracDelim.Margin = new System.Windows.Forms.Padding(2);
            this.fracDelim.Name = "fracDelim";
            this.fracDelim.Size = new System.Drawing.Size(64, 41);
            this.fracDelim.TabIndex = 27;
            this.fracDelim.Text = "/";
            this.fracDelim.UseVisualStyleBackColor = false;
            this.fracDelim.Click += new System.EventHandler(this.editorOperationBtn_Click);
            // 
            // addIm
            // 
            this.addIm.AccessibleDescription = "+";
            this.addIm.AccessibleName = "AddDelim";
            this.addIm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addIm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addIm.Enabled = false;
            this.addIm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIm.Font = new System.Drawing.Font("Segoe UI", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addIm.Location = new System.Drawing.Point(70, 272);
            this.addIm.Margin = new System.Windows.Forms.Padding(2);
            this.addIm.Name = "addIm";
            this.addIm.Size = new System.Drawing.Size(64, 41);
            this.addIm.TabIndex = 28;
            this.addIm.Text = "+i";
            this.addIm.UseVisualStyleBackColor = false;
            this.addIm.Click += new System.EventHandler(this.editorOperationBtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 27);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 32);
            this.flowLayoutPanel1.TabIndex = 39;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.Controls.Add(this.trackBar, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.baseUpDown, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FBtn, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CBtn, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.EBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.DBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ABtn, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 384);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(269, 135);
            this.tableLayoutPanel2.TabIndex = 40;
            // 
            // trackBar
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.trackBar, 4);
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar.LargeChange = 2;
            this.trackBar.Location = new System.Drawing.Point(3, 98);
            this.trackBar.Margin = new System.Windows.Forms.Padding(3, 8, 3, 2);
            this.trackBar.Maximum = 16;
            this.trackBar.Minimum = 2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(266, 35);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 10;
            this.trackBar.ValueChanged += new System.EventHandler(this.base_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(280, 540);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Interface_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseUpDown)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DBtn;
        private System.Windows.Forms.Button EBtn;
        private System.Windows.Forms.Button FBtn;
        private System.Windows.Forms.Button ABtn;
        private System.Windows.Forms.Button BBtn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button sevenBtn;
        private System.Windows.Forms.Button eightBtn;
        private System.Windows.Forms.Button nineBtn;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button fourBtn;
        private System.Windows.Forms.Button fiveBtn;
        private System.Windows.Forms.Button sixBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button oneBtn;
        private System.Windows.Forms.Button twoBtn;
        private System.Windows.Forms.Button threeBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Button zeroBtn;
        private System.Windows.Forms.Button pointBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button inverseBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button MCBtn;
        private System.Windows.Forms.Button MRBtn;
        private System.Windows.Forms.Button MPlusBtn;
        private System.Windows.Forms.Button MSBtn;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button backspaceBtn;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown baseUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button subIm;
        private System.Windows.Forms.Button fracDelim;
        private System.Windows.Forms.Button addIm;
        private System.Windows.Forms.ToolStripMenuItem fractionalNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complexNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pNumberToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar;
    }
}