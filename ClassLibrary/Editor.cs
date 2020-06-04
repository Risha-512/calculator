namespace ClassLibrary
{
    public abstract class Editor
    {
        protected virtual string delim { get; }
        protected static string point => ".";
        
        public string numberString { set; get; }

        protected const string zero = "0";

        protected Editor(string n = zero)
        {
            numberString = n;
        }

        private bool IsZero() => numberString == zero;

        public virtual Editor ChangeSign()
        {
            if (IsZero()) return this;
            
            if (numberString[0] == '-')
                numberString = numberString.Remove(0, 1);
            else
                numberString = "-" + numberString;

            return this;
        }

        public virtual Editor AddDigit(string digit)
        {
            if (numberString == zero) 
                numberString = digit;
            else 
                numberString += digit;
            
            return this;
        }

        public virtual Editor DeleteChar()
        {
            if (numberString.Length > 1 && (numberString[0] != '-' || numberString.Length != 2))
                numberString = numberString.Remove(numberString.Length - 1);
            else
                numberString = zero;

            return this;
        }

        protected Editor AddUniqueStr(string str)
        {
            if (!numberString.Contains(str))
                numberString += str;

            return this;
        }

        public virtual Editor AddPoint() => AddUniqueStr(point);

        public abstract Editor AddDelim(string add = "");

        public virtual Editor Clear()
        {
            numberString = zero;
            return this;
        }

        public virtual Editor SetNumber(Number n)
        {
            numberString = n.ToString();
            return this;
        }

        protected bool ContainDelim() => numberString.Contains(delim);
    }
}