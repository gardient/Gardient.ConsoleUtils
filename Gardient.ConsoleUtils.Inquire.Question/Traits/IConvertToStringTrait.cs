using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IConvertToStringTrait<TResult>
    {
        IConvertToStringComponent<TResult> Convert { get; set; }
    }
}
