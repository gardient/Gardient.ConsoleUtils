using System;
using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    internal class ParseComponent<TInput, TResult> : IParseComponent<TInput, TResult>
    {
        public ParseComponent(Func<TInput, TResult> parseFn)
        {
            Parse = parseFn;
        }

        public Func<TInput, TResult> Parse { get; set; }
    }
}
