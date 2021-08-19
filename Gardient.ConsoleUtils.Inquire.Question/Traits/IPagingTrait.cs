using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IPagingTrait<TResult>
    {
        IPagingComponent<TResult> Paging { get; set; }
    }
}
