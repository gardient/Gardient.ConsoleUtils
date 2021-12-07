using System;

namespace Gardient.ConsoleUtils.AppConsole
{
    public interface IConsole
    {
        int CursorLeft { get; }

        int CursorTop { get; }

        int WindowWidth { get; }

        int WindowHeight { get; }

        void Clear();

        void ClearLine(int y);

        void PositionWrite(string text, int x = 0, int y = 0, ConsoleColor color = ConsoleColor.White);

        void PositionWriteLine(string text, int x = 0, int y = 0, ConsoleColor color = ConsoleColor.White);

        string Read();

        string Read(out ConsoleKey? intteruptedKey, Func<char, bool> allowTypeFn, params ConsoleKey[] interruptKeys);

        ConsoleKeyInfo ReadKey();

        ConsoleKeyInfo ReadKey(out bool isCanceled);

        void SetCursorPosition(int v, int cursorTop);

        void Write(string text, ConsoleColor color = ConsoleColor.White);

        void WriteError(string error);

        void WriteLine(string text = " ", ConsoleColor color = ConsoleColor.White);
    }
}
