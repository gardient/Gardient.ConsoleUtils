using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    internal class NoConfirmationComponent<TResult> : IConfirmComponent<TResult>
    {
        public bool Confirm(TResult result)
        {
            return false;
        }
    }
}
