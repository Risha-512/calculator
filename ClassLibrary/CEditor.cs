using System;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class CEditor : Editor
    {
        protected sealed override string delim => "i";

        private PEditor re = new PEditor();
        private PEditor im = new PEditor("");

        public CEditor(string n = zero) : base(n)
        {
            var complex = n.Split(delim[0]);
            if (complex[0].EndsWith("-")) 
                complex[1] = "-" + complex[1];
            complex[0].Remove(complex[0].Length - 1);
        }

        public override Editor ChangeSign()
        {
            base.ChangeSign();
            var index = numberString.IndexOf(delim, StringComparison.Ordinal);
            if (index < 0) 
                return this;

            if (index == 0) 
                numberString = "-" + numberString;
            else
            {
                var numStr = numberString.ToCharArray();
                numStr[index - 1] = numStr[index - 1] == '-' ? '+' : '-';
                numberString = new string(numStr);
            }
            
            return this;
        }

        public override Editor AddDigit(string digit)
        {
            if (ContainDelim())
            {
                if (im.numberString == zero && digit == zero)
                    return this;
                base.AddDigit(digit);
                im.AddDigit(digit);
            }
            else
            {
                if (re.numberString == zero && digit == zero)
                    return this;
                base.AddDigit(digit);
                re.AddDigit(digit);
            }

            return this;
        }

        public override Editor DeleteChar()
        {
            if (numberString.EndsWith(delim) && numberString.Length > 1)
                base.DeleteChar();
            base.DeleteChar();
            return this;
        }

        public override Editor AddDelim(string add = "")
        {
            if (numberString.EndsWith(point) || ContainDelim()) 
                return this;

            if (numberString == zero)
            {
                numberString = "";
                if (add == "+")
                    add = "";
            }
            AddUniqueStr(add + delim);

            return this;
        }

        public override Editor AddPoint()
        {
            if (ContainDelim())
            {
                if (numberString.EndsWith(delim))
                    return this;
                im.AddPoint();
                if (new Regex(@"[.]").Matches(point).Count == 1 && !numberString.Contains(im.numberString))
                    numberString += point;
            }
            else
            {
                re.AddPoint();
                base.AddPoint();
            }

            return this;
        }

        public override Editor Clear()
        {
            base.Clear();
            re.Clear();
            im = new PEditor("");
            return this;
        }

        public override Editor SetNumber(Number n)
        {
            base.SetNumber(n as CNumber);
            re.SetNumber((n as CNumber)?.real);
            im.SetNumber((n as CNumber)?.imaginary);
            return this;
        }
    }
}