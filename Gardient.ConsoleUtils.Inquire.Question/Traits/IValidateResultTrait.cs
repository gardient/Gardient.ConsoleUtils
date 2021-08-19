using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IValidateResultTrait<T>
    {
        IValidateComponent<T> ResultValidators { get; set; }
    }
}
