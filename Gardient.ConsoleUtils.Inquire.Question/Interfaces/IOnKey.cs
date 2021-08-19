using System;

namespace Gardient.ConsoleUtils.Inquire.Question.Interfaces
{
    public interface IOnKey
    {
        bool IsInterrupted { get; }

        void OnKey(ConsoleKey? key);
    }
}
