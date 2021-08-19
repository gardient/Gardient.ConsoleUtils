using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IValidateInputTrait<TInput>
    {
        IValidateComponent<TInput> InputValidators { get; set; }
    }
}
