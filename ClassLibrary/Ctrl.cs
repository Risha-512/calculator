using System;

namespace ClassLibrary
{
    public class Ctrl
    {
        private enum CtrlState
        {
            Editing = 1,
            FuncDone,
            ValueReset,
            ExpDone,
            OpChange,
            Error
        }
        public enum EditorCommand
        {
            AddDigit = 1,
            DeleteChar,
            Clear,
            ChangeSign,
            AddPoint,
            AddDelim,
            Reset
        }
        public enum CalculatorCommand
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide,
            Square,
            Inverse,
            Calculate
        }
        
        public enum MemoryCommand
        {
            Clear = 1,
            Write,
            Read,
            Add
        }

        private Number number;
        private Editor editor;
        private Processor proc;
        private Memory memory;
        private CtrlState state;

        public Ctrl()
        {
            number = new PNumber();
            editor = new PEditor(number.ToString());
            proc = new Processor();
            memory = new Memory(new PNumber());
            state = CtrlState.Editing;
        }

        public Processor.Mode GetMode() => proc.currentMode;

        public int GetNumberBase() => (number is PNumber n) ? n.numBase : 10;

        public Editor ChangeMode(Processor.Mode mode)
        {
            if (proc.currentMode == mode) 
                return editor;
            memory.Reset(mode);
            switch (mode)
            {
                case Processor.Mode.PNumber:
                    number = new PNumber();
                    editor = new PEditor();
                    break;
                case Processor.Mode.Fractional:
                    number = new FNumber();
                    editor = new FEditor();
                    break;
                case Processor.Mode.Complex:
                    number = new CNumber();
                    editor = new CEditor();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
            proc.currentMode = mode;
            return editor;
        }

        public string ChangeNumberBase(int numBase)
        {
            if (!(number is PNumber n))
                return number.ToString();

            (n.SetNumberFromString(editor.numberString, n.numBase) as PNumber)?.ChangeBase(numBase);
            
            return editor.SetNumber(n).numberString;
        }

        public string ExecuteEditorCommand(EditorCommand cmd, string symb = "")
        {
            if (state == CtrlState.OpChange || state == CtrlState.Error)
                editor.Clear();
            state = CtrlState.Editing;
            switch (cmd)
            {
                case EditorCommand.AddDigit:
                    return editor.AddDigit(symb).numberString;
                case EditorCommand.AddPoint:
                    return editor.AddPoint().numberString;
                case EditorCommand.AddDelim:
                    return editor.AddDelim(symb).numberString;
                case EditorCommand.ChangeSign:
                    return editor.ChangeSign().numberString;
                case EditorCommand.DeleteChar:
                    return editor.DeleteChar().numberString;
                case EditorCommand.Clear:
                    proc.leftNumber.Reset();
                    state = CtrlState.ValueReset;
                    return editor.Clear().numberString;
                case EditorCommand.Reset:
                    return Reset();
                default:
                    throw new ArgumentOutOfRangeException(nameof(cmd), cmd, null);
            }
        }

        public string ExecuteCalculatorCommand(CalculatorCommand cmd)
        {
            if (state == CtrlState.Error)
                editor.Clear();
            try
            {
                switch (cmd)
                {
                    case CalculatorCommand.Add:
                        SetOperation(Processor.Operation.Add);
                        break;
                    case CalculatorCommand.Subtract:
                        SetOperation(Processor.Operation.Subtract);
                        break;
                    case CalculatorCommand.Multiply:
                        SetOperation(Processor.Operation.Multiply);
                        break;
                    case CalculatorCommand.Divide:
                        SetOperation(Processor.Operation.Divide);
                        break;
                    case CalculatorCommand.Square:
                        ExecuteFunction(Processor.Function.Square);
                        break;
                    case CalculatorCommand.Inverse:
                        ExecuteFunction(Processor.Function.Inverse);
                        break;
                    case CalculatorCommand.Calculate:
                        if (state == CtrlState.Editing)
                        {
                            if (proc.operation == Processor.Operation.None)
                            {
                                if (number is FNumber n)
                                {
                                    SetNumberFromEditor();
                                    editor.numberString = n.Simplify().ToString();
                                }
                                break;
                            }
                            SetNumberFromEditor();
                            proc.SetRightNumber(number);
                            proc.ExecuteOperation();
                            editor.numberString = proc.GetLeftNumberString();
                        }
                        else if (state == CtrlState.ExpDone || state == CtrlState.ValueReset
                                                            || (state == CtrlState.FuncDone && proc.operation != Processor.Operation.None))
                        {
                            proc.ExecuteOperation();
                            editor.numberString = proc.GetLeftNumberString();
                        }
                        state = CtrlState.ExpDone;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(cmd), cmd, null);
                }
            }
            catch (Exception e)
            {
                state = CtrlState.Error;
                Reset();
                editor.numberString = "Error";
            }
            return editor.numberString;
        }

        private void SetNumberFromEditor()
        {
            if (number is PNumber n)
                n.SetNumberFromString(editor.numberString, n.numBase);
            else
                number.SetNumberFromString(editor.numberString);
        }

        private void SetOperation(Processor.Operation op)
        {
            state = CtrlState.OpChange;
            SetNumberFromEditor();
            proc.SetOperation(op);
            proc.SetLeftNumber(number);
        }

        private void ExecuteFunction(Processor.Function func)
        {
            state = CtrlState.FuncDone;
            SetNumberFromEditor();
            proc.SetFunction(func);
            proc.SetRightNumber(number);
            proc.ExecuteFunction();
            editor.numberString = proc.GetRightNumberString();
        }
        private string Reset()
        {
            proc.ResetProcess(GetMode());
            number.Reset();
            return editor.Clear().numberString;
        }

        public bool GetMemoryState() => memory.IsMemoryOn();

        public string ExecuteMemoryCommand(MemoryCommand cmd)
        {
            switch (cmd)
            {
                case MemoryCommand.Add:
                    var memoryNumber1 = number is PNumber n1 
                        ? n1.SetNumberFromString(editor.numberString, n1.numBase) 
                        : number.SetNumberFromString(editor.numberString);
                    memory.Add(memoryNumber1);
                    break;
                case MemoryCommand.Clear:
                    memory.Clear();
                    break;
                case MemoryCommand.Write:
                    var memoryNumber2 = number is PNumber n2
                        ? n2.SetNumberFromString(editor.numberString, n2.numBase) 
                        : number.SetNumberFromString(editor.numberString);
                    memory.WriteNumber(memoryNumber2);
                    break;
                case MemoryCommand.Read:
                    if (memory.number is PNumber n3 && number is PNumber n4)
                        n3.ChangeBase(n4.numBase);
                    number = memory.number.Copy();
                    proc.SetLeftNumber(number);
                    editor.numberString = number.ToString();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cmd), cmd, null);
            }
            return editor.numberString;
        }
    }
}