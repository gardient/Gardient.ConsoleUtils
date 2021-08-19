using System;

namespace Gardient.ConsoleUtils.Inquire.Question.Interfaces
{
    public interface IParseComponent<TInput, TResult>
    {
        Func<TInput, TResult> Parse { get; }
    }
}
