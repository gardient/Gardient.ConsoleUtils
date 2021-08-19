using System;

namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IParseComponent<TInput, TResult>
    {
        Func<TInput, TResult> Parse { get; }
    }
}
