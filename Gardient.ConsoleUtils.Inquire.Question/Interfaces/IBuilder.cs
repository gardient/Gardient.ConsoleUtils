﻿namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IBuilder<TQuestion, TResult> where TQuestion : IQuestion<TResult>
    {
        TQuestion Build();

        TResult Prompt();
    }
}
