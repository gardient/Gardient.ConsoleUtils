using System;
using System.Linq;
using Gardient.ConsoleUtils.AppConsole;
using Gardient.ConsoleUtils.Inquire.Question.Questions;
using Gardient.ConsoleUtils.Inquire.Question.Traits;

namespace Gardient.ConsoleUtils.Inquire.Question.Builders
{
    public class ExtendedBuilder : InputBuilder<InputKey<ConsoleKey>, ConsoleKey, ConsoleKey>
    {
        internal ExtendedBuilder(string message, IConsole console, params ConsoleKey[] @params) : base(console)
        {
            this.RenderQuestion(message, this, this, Console);

            this.Parse(value => { return value; });

            InputValidators.Add(
            value =>
            {
                return @params.Any(p => p == value);
            },
            value =>
            {
                string keys = " Press : ";
                foreach (var key in @params)
                {
                    keys += $"[{(char)key}] ";
                }

                return keys;
            });
        }

        public override InputKey<ConsoleKey> Build()
        {
            return new InputKey<ConsoleKey>(Confirm, RenderQuestion, Input, Parse, ResultValidators, InputValidators, DisplayError, Default, OnKey);
        }
    }
}
