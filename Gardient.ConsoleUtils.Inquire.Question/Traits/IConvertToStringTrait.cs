using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IConvertToStringTrait<TResult>
    {
        IConvertToStringComponent<TResult> Convert { get; set; }
    }
}
