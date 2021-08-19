using System.Collections.Generic;

namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IPagingComponent<TResult>
    {
        List<TResult> CurrentPage { get; }

        int CurrentPageNumber { get; }

        Dictionary<int, List<TResult>> PagedChoices { get; }

        bool Next();

        bool Previous();
    }
}
