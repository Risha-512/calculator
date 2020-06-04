using System;

namespace ClassLibrary
{
    public class Processor
    {
        private Number rightNumber { set; get; }
        public Number leftNumber { private set; get; }

        public enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide,
            None
        }

        public enum Function
        {
            Square = 1,
            Inverse,
            None
        }
        
        public enum Mode
        {
            PNumber = 1,
            Fractional,
            Complex
        }

        public Operation operation { private set; get; }
        public Function function { private set; get; }
        public Mode currentMode { set; get; }
        
        public Processor() => ResetProcess(Mode.PNumber);

        public void SetLeftNumber(Number n) => leftNumber = n.Copy();

        public void SetRightNumber(Number n) => rightNumber = n.Copy();

        public void SetOperation(Operation o) => operation = o;

        public void SetFunction(Function f) => function = f;

        public string GetLeftNumberString() => leftNumber.ToString();

        public string GetRightNumberString() => rightNumber.ToString();
        
        public void ResetProcess(Mode mode)
        {
            currentMode = mode;
            switch (mode)
            {
                case Mode.PNumber:
                    leftNumber = new PNumber();
                    rightNumber = new PNumber();
                    break;
                case Mode.Fractional:
                    leftNumber = new FNumber();
                    rightNumber = new FNumber();
                    break;
                case Mode.Complex:
                    leftNumber = new CNumber();
                    rightNumber = new CNumber();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
            operation = Operation.None;
            function = Function.None;
        }

        public void ExecuteOperation()
        {
            switch (operation)
            {
                case Operation.Add:
                    leftNumber.Add(rightNumber);
                    break;
                case Operation.Subtract:
                    leftNumber.Subtract(rightNumber);
                    break;
                case Operation.Multiply:
                    leftNumber.Multiply(rightNumber);
                    break;
                case Operation.Divide:
                    leftNumber.Divide(rightNumber);
                    break;
                case Operation.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void ExecuteFunction()
        {
            switch (function)
            {
                case Function.Inverse:
                    rightNumber.Inverse();
                    break;
                case Function.Square:
                    rightNumber.Square();
                    break;
                case Function.None:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
