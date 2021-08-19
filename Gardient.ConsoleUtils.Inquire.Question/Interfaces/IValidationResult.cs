namespace Gardient.ConsoleUtils.Inquire.Question.Interfaces
{
    public interface IValidationResult
    {
        string ErrorMessage { get; }

        bool HasError { get; }
    }
}
