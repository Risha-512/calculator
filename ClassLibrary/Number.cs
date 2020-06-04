using System;

namespace ClassLibrary
{
    public abstract class Number
    {
        protected const double F_EPS = 1e-7;
        protected const double D_EPS = 1e-15;
       
        public abstract Number SetNumberFromString(string n, int additional = 0);
        public abstract Number Add(Number n);
        public abstract Number Multiply(Number n);
        public abstract Number Subtract(Number n);
        public abstract Number Divide(Number n);
        public abstract Number Inverse();
        public Number Square() => Multiply(Copy());
        public abstract bool IsZero();
        public abstract Number ChangeSign();
        public abstract Number Reset();
        public abstract Number Copy();
        
        protected void CheckDenominator(Number dn)
        {
            if (dn.IsZero())
                throw new ArgumentException("Denominator can't be zero", nameof(dn));
        }
    }
}
