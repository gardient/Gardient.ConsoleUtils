using System;
using System.Collections.Generic;

namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IWaitForInputComponent<TInput>
    {
        Func<char, bool> AllowTypeFn { get; set; }

        List<ConsoleKey> IntteruptedKeys { get; set; }

        TInput WaitForInput();
    }
}
