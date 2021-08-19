namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IDefaultValueComponent<TResult>
    {
        bool HasDefault { get; }

        TResult Value { get; }
    }
}
