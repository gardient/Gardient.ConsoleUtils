using System;
using Gardient.ConsoleUtils.AppConsole;
using Gardient.ConsoleUtils.Inquire.Questions;
using Gardient.ConsoleUtils.Inquire.Traits;

namespace Gardient.ConsoleUtils.Inquire.Builders
{
    public class InputStringBuilder : InputBuilder<Input<string>, string, string>
    {
        internal InputStringBuilder(string message, IConsole console) : base(console)
        {
            this.RenderQuestion(message, this, this, Console);
            this.Parse(value => { return value; });
            this.Input(Console, ConsoleKey.Escape);

            InputValidators.Add(value => { return string.IsNullOrEmpty(value) == false || Default.HasDefault; }, "Empty line");
        }

        public override Input<string> Build()
        {
            return new Input<string>(Confirm, RenderQuestion, Input, Parse, ResultValidators, InputValidators, DisplayError, Default, OnKey);
        }
    }
}
