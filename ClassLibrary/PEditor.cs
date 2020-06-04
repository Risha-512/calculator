namespace ClassLibrary
{
    public class PEditor : Editor
    {
        protected sealed override string delim => point;

        public PEditor(string n = zero) : base(n) {}

        public override Editor ChangeSign() => (PEditor) base.ChangeSign();

        public override Editor AddDigit(string digit) => (PEditor) base.AddDigit(digit);

        public override Editor DeleteChar() => (PEditor) base.DeleteChar();

        public override Editor AddDelim(string add = "") => (PEditor) base.AddPoint();

        public override Editor Clear() => (PEditor) base.Clear();

        public override Editor SetNumber(Number n) => (PEditor) base.SetNumber(n as PNumber);
    }
}