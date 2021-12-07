using System;
using System.Collections.Generic;
using Gardient.ConsoleUtils.AppConsole;
using Gardient.ConsoleUtils.Inquire.Interfaces;
using Gardient.ConsoleUtils.Inquire.Traits;

namespace Gardient.ConsoleUtils.Inquire.Components
{
    internal class DisplayExtendedChoices<TResult> : IRenderChoices<TResult>
    {
        private Dictionary<ConsoleKey, TResult> _choicesDictionary;

        private IConsole _console;

        private IConvertToStringTrait<TResult> _convertToString;

        public DisplayExtendedChoices(Dictionary<ConsoleKey, TResult> choicesDictionary, IConvertToStringTrait<TResult> convertToString, IConsole console)
        {
            _choicesDictionary = choicesDictionary;
            _convertToString = convertToString;
            _console = console;
        }

        public void ClearChoices()
        {
            for (int i = 0; i < _choicesDictionary.Count; i++)
            {
                _console.ClearLine(i + Consts.CURSOR_OFFSET);
            }
        }

        public void Render()
        {
            var index = 0;
            foreach (var choice in _choicesDictionary)
            {
                _console.PositionWriteLine($"[{choice.Key}] {_convertToString.Convert.Run(choice.Value)}", 0, index + Consts.CURSOR_OFFSET);
                index++;
            }
        }

        public void Select(int index)
        {
        }

        public void UnSelect(int index)
        {
        }
    }
}
