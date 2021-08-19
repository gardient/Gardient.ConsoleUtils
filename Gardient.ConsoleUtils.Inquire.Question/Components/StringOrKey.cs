using System;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    public class StringOrKey
    {
        internal StringOrKey(string value, ConsoleKey? interruptKey)
        {
            Value = value;
            InterruptKey = interruptKey;
        }

        public ConsoleKey? InterruptKey { get; }

        public string Value { get; }
    }
}
