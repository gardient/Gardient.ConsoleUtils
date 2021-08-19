using System;
using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    internal class ParseStructComponent<TResult> : IParseComponent<string, TResult> where TResult : struct
    {
        public ParseStructComponent()
        {
            Parse = value => { return value.To<TResult>(); };
        }

        public Func<string, TResult> Parse { get; }
    }
}
