using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IWaitForInputTrait<TResult>
    {
        IWaitForInputComponent<TResult> Input { get; set; }
    }
}
