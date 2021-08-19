﻿using System;
using System.Collections.Generic;
using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    internal class ParseListComponent<TResult> : IParseComponent<int, TResult>
    {
        private List<TResult> _choices;

        public ParseListComponent(List<TResult> choices)
        {
            _choices = choices;
            Parse = value => { return _choices[value]; };
        }

        public Func<int, TResult> Parse { get; }
    }
}
