using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IParseTrait<TInput, TResult>
    {
        IParseComponent<TInput, TResult> Parse { get; set; }
    }
}
