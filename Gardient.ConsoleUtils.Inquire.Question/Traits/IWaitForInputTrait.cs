using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IWaitForInputTrait<TResult>
    {
        IWaitForInputComponent<TResult> Input { get; set; }
    }
}
