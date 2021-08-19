using System;
using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Components
{
    internal class ConvertToStringComponent<TResult> : IConvertToStringComponent<TResult>
    {
        public ConvertToStringComponent(Func<TResult, string> convertToStringFn = null)
        {
            if (convertToStringFn != null)
            {
                Run = convertToStringFn;
            }
        }

        public Func<TResult, string> Run { get; } = value => { return value.ToString(); };
    }
}
