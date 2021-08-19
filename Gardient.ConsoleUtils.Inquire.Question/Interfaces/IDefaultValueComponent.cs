namespace Gardient.ConsoleUtils.Inquire.Question.Interfaces
{
    public interface IDefaultValueComponent<TResult>
    {
        bool HasDefault { get; }

        TResult Value { get; }
    }
}
