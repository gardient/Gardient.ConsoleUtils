namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IValidationResult
    {
        string ErrorMessage { get; }

        bool HasError { get; }
    }
}
