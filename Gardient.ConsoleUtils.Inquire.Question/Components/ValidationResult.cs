using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Components
{
    internal class ValidationResult : IValidationResult
    {
        public ValidationResult()
        {
            HasError = false;
        }

        public ValidationResult(string errorMessage)
        {
            HasError = true;
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; }

        public bool HasError { get; }
    }
}
