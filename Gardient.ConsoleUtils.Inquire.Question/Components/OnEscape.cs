using System;
using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    public class OnEscape : IOnKey
    {
        public OnEscape()
        {
        }

        public bool IsInterrupted { get; set; }

        public void OnKey(ConsoleKey? key)
        {
            IsInterrupted = key == ConsoleKey.Escape;
        }
    }
}
