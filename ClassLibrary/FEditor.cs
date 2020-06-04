using System;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public sealed class FEditor : Editor
    {
        protected override string delim => "/";

        private Editor numerator;
        private Editor denominator;

        public FEditor(string n = zero) : base(n)
        {
            var fraction = n.Split(delim[0]);
            numerator = new PEditor(fraction[0]);

            if (fraction.Length == 2)
                denominator = new PEditor(fraction[1]);
            else
                denominator = new PEditor("");
        }

        public override Editor ChangeSign()
        {
            base.ChangeSign();
            numerator.ChangeSign();
            return this;
        }

        public override Editor AddDigit(string digit)
        {
            if (ContainDelim())
            {
                if (denominator.numberString == zero && digit == zero) 
                    return this;
                base.AddDigit(digit);
                denominator.AddDigit(digit);
            }
            else
            {
                if (numerator.numberString == zero && digit == zero)
                    return this;
                base.AddDigit(digit);
                numerator.AddDigit(digit);
            }

            return this;
        }

        public override Editor DeleteChar()
        {
            base.DeleteChar();
            if (ContainDelim())
                denominator.DeleteChar();
            else
                numerator.DeleteChar();

            return this;
        }

        public override Editor AddDelim(string add = "")
        {
            if (!numberString.EndsWith(point))
                AddUniqueStr(add + delim);
            return this;
        }

        public override Editor AddPoint()
        {
            if (ContainDelim())
            {
                if (numberString.EndsWith(delim))
                    return this;
                denominator.AddPoint();
                if (new Regex(@"[.]").Matches(denominator.numberString).Count == 1 
                    && !numberString.Split(delim[0])[1].Contains(denominator.numberString))
                    numberString += point;
            }
            else
            {
                numerator.AddPoint();
                base.AddPoint();
            }

            return this;
        }

        public override Editor Clear()
        {
            base.Clear();
            numerator.Clear();
            denominator.Clear();
            return this;
        }

        public override Editor SetNumber(Number n)
        {
            base.SetNumber(n as FNumber);
            numerator = new PEditor((n as FNumber)?.numerator.ToString());
            denominator = new PEditor((n as FNumber)?.denominator.ToString());
            return this;
        }
    }
}