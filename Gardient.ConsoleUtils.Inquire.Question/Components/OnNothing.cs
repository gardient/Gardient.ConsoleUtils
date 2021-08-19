using System;
using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Components
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
