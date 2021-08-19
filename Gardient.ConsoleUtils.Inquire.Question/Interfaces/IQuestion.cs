namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IQuestion<TResult>
    {
        TResult Prompt();
    }
}
