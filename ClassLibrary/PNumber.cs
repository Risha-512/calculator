using System;

namespace ClassLibrary
{
    public sealed class PNumber : Number
    {
        public double decimalNum { private set; get; }
        public int numBase { private set; get; }

        public PNumber(string n, int nBase) => SetNumberFromString(n, nBase);
        
        public PNumber(double dNum)
        {
            numBase = 10;
            decimalNum = dNum;
        }

        public PNumber(double dNum, int nBase)
        {
            numBase = nBase;
            decimalNum = dNum;
        }

        public PNumber() => Reset();

        public override Number SetNumberFromString(string n, int nBase = 0)
        {
            if (nBase != 0)
                numBase = nBase;
            decimalNum = double.Parse(Converter.Convert(n, numBase), Converter.cultInfo);
            return this;
        }
        
        public override Number Add(Number n)
        {
            if (n is PNumber number)
                this.decimalNum += number.decimalNum;

            return this;
        }

        public override Number Multiply(Number n)
        {
            if (n is PNumber number)
                this.decimalNum *= number.decimalNum;

            return this;
        }

        public override Number Subtract(Number n)
        {
            if (n is PNumber number)
                decimalNum -= number.decimalNum;

            return this;
        }

        public override Number Divide(Number n)
        {
            CheckDenominator(n);
            
            if (n is PNumber number)
                decimalNum /= number.decimalNum;
            decimalNum = Math.Round(decimalNum, 5);

            return this;
        }

        public override Number Inverse()
        {
            decimalNum = ((PNumber) new PNumber(1, numBase).Divide(this)).decimalNum;
            return this;
        }

        public Number ChangeBase(int nBase)
        {
            numBase = nBase;
            return this;
        }

        public override bool IsZero() => Math.Abs(decimalNum) < D_EPS;

        public override Number ChangeSign() => Multiply(new PNumber(-1));

        public bool IsAbsOne() => Math.Abs(Math.Abs(decimalNum) - 1) < D_EPS;

        public override Number Reset()
        {
            decimalNum = 0.0d;
            numBase = 10;
            return this;
        }

        public override Number Copy() => new PNumber(decimalNum, numBase);

        public Number Abs() => new PNumber(Math.Abs(decimalNum), numBase);
        
        public string GetSignString() => decimalNum >= D_EPS ? "" : "-";
        
        public override string ToString() => 
            numBase == 10 
                ? decimalNum.ToString(Converter.cultInfo) 
                : Converter.Convert(decimalNum.ToString(Converter.cultInfo), 10, numBase);

        public bool IsEqualTo(PNumber n) => Math.Abs(decimalNum - n.decimalNum) <= D_EPS;
    }
}