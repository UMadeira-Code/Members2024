using Members.Core.Commands;

namespace Members.Shared.Commands
{
    public class RenameCommand : ICommand
    {
        public RenameCommand( Member member, string name )
        {
            Member = member;
            Name = name;
        }

        private Member Member { get; set; }
        private string Name { get; set; }

        public void Do()
        {
            var aux = Member.Name;
            Member.Name = Name;
            Name = aux;
        }

        public void Undo() => Do();
        public void Redo() => Do();
        public void Cancel() { }
    }
}
