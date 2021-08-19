using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IParseTrait<TInput, TResult>
    {
        IParseComponent<TInput, TResult> Parse { get; set; }
    }
}
