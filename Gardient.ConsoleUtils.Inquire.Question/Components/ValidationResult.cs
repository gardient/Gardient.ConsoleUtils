using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Components
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
