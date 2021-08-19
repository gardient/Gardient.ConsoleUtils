using System;
using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    internal class OnNothing : IOnKey
    {
        public bool IsInterrupted { get; }

        public void OnKey(ConsoleKey? key)
        {
            return;
        }
    }
}
