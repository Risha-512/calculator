using System;

namespace ClassLibrary
{
    public class Memory
    {
        public Number number { private set; get; }
        
        private enum State
        {
            On = 1,
            Off
        }
        private State memoryState { set; get; }

        public Memory(Number n)
        {
            memoryState = State.Off;
            number = n.Copy();
        }
        
        public void WriteNumber(Number n)
        {
            number = n.Copy();
            memoryState = State.On;
        }

        public void Add(Number n) => number = number.Add(n).Copy();

        public void Clear()
        {
            memoryState = State.Off;
            number.Reset();
        }

        public void Reset(Processor.Mode mode)
        {
            memoryState = State.Off;
            switch (mode)
            {
                case Processor.Mode.PNumber:
                    number = new PNumber();
                    break;
                case Processor.Mode.Fractional:
                    number = new FNumber();
                    break;
                case Processor.Mode.Complex:
                    number = new CNumber();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
        }

        public bool IsMemoryOn() => memoryState == State.On;
    }
}