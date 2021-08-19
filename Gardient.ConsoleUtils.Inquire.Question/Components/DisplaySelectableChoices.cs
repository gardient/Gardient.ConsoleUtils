﻿using System;
using System.Collections.Generic;
using Gardient.ConsoleUtils.AppConsole;
using Gardient.ConsoleUtils.Inquire.Question.Interfaces;
using Gardient.ConsoleUtils.Inquire.Question.Traits;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    internal class DisplaySelectableChoices<TResult> : IRenderChoices<TResult>
    {
        private List<Selectable<TResult>> _choices;

        private IConsole _console;

        private IConvertToStringTrait<TResult> _convert;

        public DisplaySelectableChoices(List<Selectable<TResult>> choices, IConvertToStringTrait<TResult> convert, IConsole console)
        {
            _choices = choices;
            _convert = convert;
            _console = console;
        }

        public void Render()
        {
            var index = 0;
            foreach (var choice in _choices)
            {
                _console.PositionWriteLine($"     {_convert.Convert.Run(choice.Item)}", 0, index + Consts.CURSOR_OFFSET);
                _console.PositionWriteLine(choice.IsSelected ? "*" : " ", 3, index + Consts.CURSOR_OFFSET);
                index++;
            }

            _console.SetCursorPosition(0, 0);
            _console.SetCursorPosition(0, Consts.CURSOR_OFFSET);
        }

        public void Select(int index)
        {
            _console.PositionWriteLine($"->   {_convert.Convert.Run(_choices[index].Item)}", 0, index + Consts.CURSOR_OFFSET, ConsoleColor.DarkYellow);
            _console.PositionWriteLine(_choices[index].IsSelected ? "*" : " ", 3, index + Consts.CURSOR_OFFSET, ConsoleColor.DarkYellow);
        }

        public void UnSelect(int index)
        {
            _console.PositionWriteLine($"     {_convert.Convert.Run(_choices[index].Item)}", 0, index + Consts.CURSOR_OFFSET);
            _console.PositionWriteLine(_choices[index].IsSelected ? "*" : " ", 3, index + Consts.CURSOR_OFFSET);
        }
    }
}
