using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IConfirmTrait<TResult>
    {
        IConfirmComponent<TResult> Confirm { get; set; }
    }
}
