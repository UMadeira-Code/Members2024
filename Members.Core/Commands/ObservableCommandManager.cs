using Members.Core.Observables;

namespace Members.Core.Commands
{
    public class ObservableCommandManager : Observable, ICommandManager
    {
        private readonly ICommandManager CommandManager = new CommandManager();

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
