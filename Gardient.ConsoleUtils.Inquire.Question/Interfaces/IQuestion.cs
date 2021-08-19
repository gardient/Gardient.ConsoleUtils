namespace Gardient.ConsoleUtils.Inquire.Question.Interfaces
{
    public interface IQuestion<TResult>
    {
        TResult Prompt();
    }
}
