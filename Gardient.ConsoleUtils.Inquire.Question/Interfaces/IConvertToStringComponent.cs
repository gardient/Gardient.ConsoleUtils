using System;

namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IConvertToStringComponent<TResult>
    {
        Func<TResult, string> Run { get; }
    }
}
