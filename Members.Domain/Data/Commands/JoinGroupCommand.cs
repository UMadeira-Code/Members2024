﻿using Members.Core.Commands;
using Members.Domain.Data.Entities;

namespace Members.Domain.Data.Commands
{
    public class JoinGroupCommand : ICommand
    {
        public JoinGroupCommand( Group group, Person member )
        {
            Group = group;
            Member = member;
        }

        private Group Group { get; }
        private Person Member { get; }

        public void Do() => Group.Members.Add( Member );
        public void Undo() => Group.Members.Remove( Member );
        public void Redo() => Do();
        public void Cancel() { }
    }
}
