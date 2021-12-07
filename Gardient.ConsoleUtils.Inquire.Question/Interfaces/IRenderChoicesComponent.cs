﻿namespace Gardient.ConsoleUtils.Inquire.Interfaces
{
    public interface IRenderChoices<TResult>
    {
        void Render();

        void Select(int index);

        void UnSelect(int index);

        void ClearChoices();
    }
}
