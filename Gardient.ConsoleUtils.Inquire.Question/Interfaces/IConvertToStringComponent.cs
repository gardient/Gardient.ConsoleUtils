using System;

namespace Gardient.ConsoleUtils.Inquire.Question.Interfaces
{
    public interface IConvertToStringComponent<TResult>
    {
        Func<TResult, string> Run { get; }
    }
}
