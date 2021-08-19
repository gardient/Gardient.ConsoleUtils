using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IDefaultTrait<TResult>
    {
        IDefaultValueComponent<TResult> Default { get; set; }
    }
}
