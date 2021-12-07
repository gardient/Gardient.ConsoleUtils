﻿using Gardient.ConsoleUtils.AppConsole;
using Gardient.ConsoleUtils.Inquire.Interfaces;
using Gardient.ConsoleUtils.Inquire.Traits;

namespace Gardient.ConsoleUtils.Inquire.Components
{
    internal class ConfirmPasswordComponent : IConfirmComponent<string>
    {
        private IConsole _console;
        private IWaitForInputTrait<StringOrKey> _input;

        public ConfirmPasswordComponent(IConsole console, IWaitForInputTrait<StringOrKey> input)
        {
            _console = console;
            _input = input;
        }

        public bool Confirm(string result)
        {
            //_console.Clear();
            _console.Write("Type again : ");

            var repeated = _input.Input.WaitForInput();
            if (repeated.Value != result)
            {
                _console.WriteError("Strings don't match");
                _console.ReadKey();
                return true;
            }

            return false;
        }
    }
}
