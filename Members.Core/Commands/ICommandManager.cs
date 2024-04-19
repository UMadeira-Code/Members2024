﻿namespace Members.Core.Commands
{
    public interface ICommandManager 
    {
        bool HasUndo { get; }
        bool HasRedo { get; }

        void Execute(ICommand command);
        void Undo();
        void Redo();
    }
}
