using System.Collections.Generic;
using System.Linq;

namespace Gardient.ConsoleUtils.Inquire.Components
{
    internal class SelectableListChoices<TResult> : List<Selectable<TResult>>
    {
        public SelectableListChoices(IEnumerable<TResult> choices)
        {
            Choices = choices.Select(item => new Selectable<TResult>(false, item)).ToList();
        }

        public SelectableListChoices(IList<TResult> choices)
        {
            Choices = choices.Select(item => new Selectable<TResult>(false, item)).ToList();
        }

        public List<Selectable<TResult>> Choices { get; }
    }
}
