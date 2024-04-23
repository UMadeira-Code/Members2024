using Members.Core.Observables;

namespace Members.Core.Commands
{
    public class ObservableExecutor : Observable, IExecutor
    {
        private readonly IExecutor CommandManager = new Executor();

        public bool HasUndo => CommandManager.HasUndo;

        public bool HasRedo => CommandManager.HasRedo;

        public void Execute( ICommand command )
        {
            CommandManager.Execute( command );
            InvokeNotify();
        }

        public void Undo()
        {
            CommandManager.Undo();
            InvokeNotify();
        }

        public void Redo()
        {
            CommandManager.Redo();
            InvokeNotify();
        }
    }
}
