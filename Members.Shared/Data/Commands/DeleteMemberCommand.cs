using Members.Core.Commands;
using Members.Shared.Data.Entities;

namespace Members.Models.Commands
{
    public class DeleteMemberCommand : ICommand
    {
        public DeleteMemberCommand( Member member ) 
        { 
            Member = member;
        }

        private Member Member { get; }

        public void Do()   => Member.Zombie = true;
        public void Undo() => Member.Zombie = false;
        public void Redo() => Do();
        public void Cancel() {}
    }
}
