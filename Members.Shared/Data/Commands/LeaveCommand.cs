﻿using Members.Core.Commands;
using Members.Shared.Data.Entities;

namespace Members.Models.Commands
{
    public class LeaveCommand : ICommand
    {
        public LeaveCommand(Group group, Person member)
        {
            Group  = group;
            Member = member;
        }

        private Group  Group  { get; }
        private Person Member { get; }

        public void Do()   => Group.Members.Remove(Member);
        public void Undo() => Group.Members.Add(Member);
        public void Redo() => Do();
        public void Cancel() { }
    }
}
