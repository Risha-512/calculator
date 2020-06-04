using System;

namespace ClassLibrary
{
    public sealed class FNumber : Number
    {
        public PNumber numerator { private set; get; }
        public PNumber denominator { private set; get; }

        public FNumber(double n, double dn)
        {
            numerator = new PNumber(n);
            denominator = 
                Math.Abs(dn) >= D_EPS 
                    ? new PNumber(dn) 
                    : new PNumber(1);
            CheckDenominator(denominator);
        }

        public FNumber(Number n, Number dn)
        {
            numerator = n.Copy() as PNumber;
            denominator = dn.Copy() as PNumber;
            CheckDenominator(denominator);
        }

        public FNumber() => Reset();

        public override Number SetNumberFromString(string n, int additional = 0)
        {
            var num = n.Split('/');
            denominator = num.Length == 2 
                ? new PNumber(num[1], 10) 
                : new PNumber(1, 10);
            
            CheckDenominator(denominator);
            numerator = new PNumber(num[0], 10);
            return this;
        }

        public override Number Add(Number n)
        {
            if (!(n is FNumber number)) 
                return this;
            
            if (denominator.IsEqualTo(number.denominator)) 
                numerator.Add(number.numerator);
            else
            {
                numerator.Multiply(number.denominator).Add((PNumber)number.numerator.Copy().Multiply(denominator));
                denominator.Multiply(number.denominator);
            }
            Simplify();

            return this;
        }

        public override Number Multiply(Number n)
        {
            if (!(n is FNumber number)) 
                return this;

            if (denominator.IsEqualTo(numerator))
            {
                denominator = new PNumber(1, 10);
                numerator = new PNumber(1, 10);
            }

            numerator.Multiply(number.numerator);
            denominator.Multiply(number.denominator);
            Simplify();
            
            return this;
        }

        public Number Simplify()
        {
            if (denominator.IsEqualTo(numerator))
            {
                denominator = new PNumber(1, 10);
                numerator = new PNumber(1, 10);
            }
            
            var gcd = GCD(Math.Abs(numerator.decimalNum), Math.Abs(denominator.decimalNum));
            if (gcd < F_EPS || Math.Abs(gcd - 1.0d) < F_EPS) 
                return this;
            
            numerator.Multiply(new PNumber(Math.Round(1 / gcd, 5)));
            denominator.Multiply(new PNumber(Math.Round(1 / gcd, 5)));
            
            return this;
        }
        
        public override Number Subtract(Number n) => 
            (n is FNumber) 
                ? Add(n.Multiply(new FNumber(-1, 1))) 
                : this;

        public override Number Divide(Number n)
        {
            CheckDenominator(n);

            return (n is FNumber number)
                ? Multiply(new FNumber(number.denominator.decimalNum, number.numerator.decimalNum))
                : this;
        }

        public override Number Inverse()
        {
            CheckDenominator(numerator);

            var newNum = denominator.Copy();
            denominator = (PNumber) numerator.Copy();
            numerator = (PNumber) newNum;
            return this;
        }

        public override bool IsZero() => numerator.IsZero();

        public override Number ChangeSign() => Multiply(new FNumber(-1, 1));

        public override Number Reset()
        {
            numerator = new PNumber();
            denominator = new PNumber(1);
            return this;
        }

        public override Number Copy() => new FNumber(numerator, denominator);
        
        public override string ToString()
        {
            if (IsZero()) 
                return "0";

            var sign = 
                numerator.GetSignString() == denominator.GetSignString() 
                    ? "" 
                    : "-";
            var res = sign + numerator.Abs().ToString();
            
            if (!denominator.IsAbsOne()) 
                res += "/" + denominator.Abs().ToString();

            return res;
        }

        private static float GCD(double a, double b) => 
            a < b 
                ? GCD(b, a) 
                : b < F_EPS 
                    ? (float)a
                    : GCD(b, a - Math.Floor(a / b) * b);
    }
}