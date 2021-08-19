using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Components
{
    internal class NoConfirmationComponent<TResult> : IConfirmComponent<TResult>
    {
        public bool Confirm(TResult result)
        {
            return false;
        }
    }
}
