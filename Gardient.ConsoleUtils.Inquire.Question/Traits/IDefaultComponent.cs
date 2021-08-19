using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IDefaultTrait<TResult>
    {
        IDefaultValueComponent<TResult> Default { get; set; }
    }
}
