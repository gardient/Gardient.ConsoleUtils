using System;

namespace Gardient.ConsoleUtils.Inquire
{
    public class EmptyNode : BaseNode
    {
        public EmptyNode() : base()
        {
        }

        public override bool Run()
        {
            return true;
        }

        internal override void After(Action after)
        {
        }
    }
}
