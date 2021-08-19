using System;
using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Components
{
    public class ThenComponent : IThen
    {
        private BaseNode _node;

        public ThenComponent(BaseNode node)
        {
            _node = node;
        }

        public void After(Action after)
        {
            _node.After(after);
        }
    }
}
