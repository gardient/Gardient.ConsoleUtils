﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Gardient.ConsoleUtils.AppConsole;
using Gardient.ConsoleUtils.Inquire.Components;
using Gardient.ConsoleUtils.Inquire.Interfaces;
using Gardient.ConsoleUtils.Inquire.Questions;
using Gardient.ConsoleUtils.Inquire.Traits;

namespace Gardient.ConsoleUtils.Inquire.Builders
{
    public class MenuBuilder : InputBuilder<ConsoleList<MenuAction>, int, MenuAction>, IRenderChoicesTrait<MenuAction>
    {
        internal MenuBuilder(string header, IConsole console) : base(console)
        {
            Choices = new List<MenuAction>();

            this.RenderQuestion(header, this, this, console);
            this.RenderChoices(Choices, this, Console);
            this.Parse(Choices);
            this.Input(Console, true, ConsoleKey.Enter, ConsoleKey.DownArrow, ConsoleKey.UpArrow);

            this.ConvertToString(item => item.Description);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public List<MenuAction> Choices { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public IRenderChoices<MenuAction> RenderChoices { get; set; }

        public MenuBuilder AddOption(string description, Action option)
        {
            Choices.Add(new MenuAction(description, option));
            return this;
        }

        public override ConsoleList<MenuAction> Build()
        {
            return new ConsoleList<MenuAction>(Choices, Confirm, RenderQuestion, Input, Parse, RenderChoices, ResultValidators, DisplayError, OnKey);
        }

        public override MenuAction Prompt()
        {
            var result = Build().Prompt();
            result.Action();
            return result;
        }
    }
}
