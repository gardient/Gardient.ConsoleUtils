using System;
using Gardient.ConsoleUtils.AppConsole;
using Gardient.ConsoleUtils.Inquire.Interfaces;
using Gardient.ConsoleUtils.Inquire.Traits;

namespace Gardient.ConsoleUtils.Inquire.Components
{
    internal class RenderQuestion<TResult> : IRenderQuestionComponent
    {
        private IConsole _console;

        private IConvertToStringTrait<TResult> _convert;

        private IDefaultTrait<TResult> _default;

        private string _message;

        private bool _clearConsole;

        public RenderQuestion(string message, IConvertToStringTrait<TResult> convert, IDefaultTrait<TResult> @default, IConsole console, bool clearConsole = false)
        {
            _message = message;
            _convert = convert;
            _default = @default;
            _console = console;
            _clearConsole = clearConsole;
        }

        public RenderQuestion(RenderQuestion<TResult> other, string message = null, IConvertToStringTrait<TResult> convert = null, IDefaultTrait<TResult> @default = null, IConsole console = null, bool? clearConsole = null)
        {
            _message = message ?? other._message;
            _convert = convert ?? other._convert;
            _default = @default ?? other._default;
            _console = console ?? other._console;
            _clearConsole = clearConsole ?? other._clearConsole;
        }

        public void Render()
        {
            //if (_clearConsole) _console.Clear();
            _console.Write("[?] ", ConsoleColor.Yellow);
            var question = $"{_message} : ";
            if (_default.Default.HasDefault)
            {
                question += $"[{_convert.Convert.Run(_default.Default.Value)}] ";
            }

            _console.Write(question);
            Consts.CURSOR_OFFSET = _console.CursorTop + 2;
        }
    }
}
