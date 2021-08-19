using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IConfirmTrait<TResult>
    {
        IConfirmComponent<TResult> Confirm { get; set; }
    }
}
