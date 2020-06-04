using System;

namespace ClassLibrary
{
    public sealed class CNumber : Number
    {
        public PNumber real { private set; get; }
        public PNumber imaginary { private set; get; }

        public CNumber(double re, double im)
        {
            real = new PNumber(re);
            imaginary = new PNumber(im);
        }

        public CNumber(Number re, Number im)
        {
            real = re.Copy() as PNumber;
            imaginary = im.Copy() as PNumber;
        }

        public CNumber() => Reset();

        public override Number SetNumberFromString(string n, int additional = 0)
        {
            var num = n.Split('i');

            if (num[0] != "")
            {
                switch (num[0][num[0].Length - 1])
                {
                    case '-':
                        num[1] = "-" + num[1];
                        num[0] = num[0].Remove(num[0].Length - 1);
                        break;
                    case '+':
                        num[0] = num[0].Remove(num[0].Length - 1);
                        break;
                }
                real = new PNumber(num[0] != "" ? num[0] : "0", 10);
            }
            else
                real = new PNumber();

            if (num.Length == 2)
            {
                if (num[1] != "")
                {
                    imaginary = num[1] == "-"
                        ? new PNumber(-1)
                        : new PNumber(num[1], 10);
                }
                else
                    imaginary = new PNumber(1);
            }
            else
                imaginary = new PNumber();

            return this;
        }

        public override Number Add(Number n)
        {
            if (!(n is CNumber number)) 
                return this;
            
            real.Add(number.real);
            imaginary.Add(number.imaginary);

            return this;
        }
        
        public override Number Multiply(Number n)
        {
            if (!(n is CNumber number)) 
                return this;

            var re = new PNumber(imaginary.decimalNum * number.imaginary.decimalNum);
            var im = new PNumber(real.decimalNum * number.imaginary.decimalNum);

            real.Multiply(number.real).Subtract(re);
            imaginary.Multiply(number.real).Add(im);

            return this;
        }

        public override Number Subtract(Number n)
        {
            if (!(n is CNumber number)) 
                return this;
            
            real.Subtract(number.real);
            imaginary.Subtract(number.imaginary);

            return this;
        }

        public override Number Divide(Number n)
        {
            CheckDenominator(n);
            
            if (!(n is CNumber number)) 
                return this;
            
            // a = real, b = imaginary, c = number.real, d = number.imaginary
            
            // b * d
            var reNum = new PNumber(imaginary.decimalNum * number.imaginary.decimalNum);
            // a * d
            var imNum = new PNumber(real.decimalNum * number.imaginary.decimalNum);
            // c^2 + d^2
            var denom = new PNumber((Math.Pow(number.real.decimalNum, 2) 
                                      + Math.Pow(number.imaginary.decimalNum, 2)));

            // (a * c + b * d) / (c^2 + d^2)
            real.Multiply(number.real).Add(reNum).Divide(denom);
            // (b * c - a * d) / (c^2 + d^2)
            imaginary.Multiply(number.real).Subtract(imNum).Divide(denom);

            return this;
        }

        public override Number Inverse()
        {
            var res = new CNumber(1, 0).Divide(this);
            real = (res as CNumber)?.real;
            imaginary = (res as CNumber)?.imaginary;
            return this;
        }

        public override bool IsZero() => real.IsZero() && imaginary.IsZero();

        public override Number ChangeSign() => Multiply(new CNumber(-1, 0));

        public override Number Reset()
        {
            real = new PNumber();
            imaginary = new PNumber(1, 10);
            return this;
        }

        public override Number Copy() => new CNumber(real, imaginary);

        public override string ToString()
        {
            if (IsZero()) 
                return "0";
            
            var reStr = "";
            var imStr = "i";
            
            if (imaginary.IsZero()) 
                imStr = "";
            else
            {
                var sign = imaginary.GetSignString();

                if (sign == "" && !real.IsZero()) 
                    sign = "+";
                if (!imaginary.IsAbsOne()) 
                    imStr += imaginary.Abs().ToString();

                imStr = sign + imStr;
            }

            if (!real.IsZero()) 
                reStr = real.ToString();

            return reStr + imStr;
        }
    }
}