using System;

namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IOnKey
    {
        bool IsInterrupted { get; }

        void OnKey(ConsoleKey? key);
    }
}
