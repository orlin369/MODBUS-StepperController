using System;

namespace StepperControl.Messages
{
    public class MessageInt : EventArgs
    {
        public int Value { get; private set; }

        public MessageInt(int value)
        {
            this.Value = value;
        }
    }
}
