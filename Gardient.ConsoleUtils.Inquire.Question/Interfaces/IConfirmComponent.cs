namespace Gardient.ConsoleUtils.Inquire.Question.Interfaces
{
    public interface IConfirmComponent<TResult>
    {
        bool Confirm(TResult result);
    }
}
