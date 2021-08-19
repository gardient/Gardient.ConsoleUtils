using Gardient.ConsoleUtils.Inquire.Question.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Question.Traits
{
    public interface IRenderChoicesTrait<TResult>
    {
        IRenderChoices<TResult> RenderChoices { get; set; }
    }
}
