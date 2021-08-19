using Gardient.ConsoleUtils.Inquire.Interfaces;

namespace Gardient.ConsoleUtils.Inquire.Traits
{
    public interface IRenderChoicesTrait<TResult>
    {
        IRenderChoices<TResult> RenderChoices { get; set; }
    }
}
