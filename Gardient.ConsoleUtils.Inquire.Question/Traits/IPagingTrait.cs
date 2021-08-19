using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IPagingTrait<TResult>
    {
        IPagingComponent<TResult> Paging { get; set; }
    }
}
