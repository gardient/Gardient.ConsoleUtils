using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IValidateResultTrait<T>
    {
        IValidateComponent<T> ResultValidators { get; set; }
    }
}
