namespace Gardient.ConsoleUtils.Inquire.Question.Interfaces
{
    public interface IBuilder<TQuestion, TResult> where TQuestion : IQuestion<TResult>
    {
        TQuestion Build();

        TResult Prompt();
    }
}
