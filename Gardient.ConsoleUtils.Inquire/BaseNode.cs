using System;

namespace Gardient.ConsoleUtils.Inquire
{
    public abstract class BaseNode
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public abstract bool Run();

        internal abstract void After(Action after);
    }
}
