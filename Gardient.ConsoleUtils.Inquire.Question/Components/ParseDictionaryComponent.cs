﻿using System;
using System.Collections.Generic;
using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    internal class ParseDictionaryComponent<TKey, TResult> : IParseComponent<TKey, TResult>
    {
        private Dictionary<TKey, TResult> _choices;

        public ParseDictionaryComponent(Dictionary<TKey, TResult> choices)
        {
            _choices = choices;
            Parse = value => { return _choices[value]; };
        }

        public Func<TKey, TResult> Parse { get; }
    }
}
