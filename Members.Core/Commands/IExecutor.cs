namespace Members.Core.Commands
{
    public interface IExecutor 
    {
        bool HasUndo { get; }
        bool HasRedo { get; }

        void Execute( ICommand command );
        void Undo();
        void Redo();
    }
}
