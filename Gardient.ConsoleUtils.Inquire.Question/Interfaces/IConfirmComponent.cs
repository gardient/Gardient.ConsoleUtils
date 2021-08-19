namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IConfirmComponent<TResult>
    {
        bool Confirm(TResult result);
    }
}
