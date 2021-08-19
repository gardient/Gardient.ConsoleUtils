using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IValidateInputTrait<TInput>
    {
        IValidateComponent<TInput> InputValidators { get; set; }
    }
}
