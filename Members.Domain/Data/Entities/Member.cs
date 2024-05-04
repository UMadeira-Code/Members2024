﻿using Members.Core.Data;

namespace Members.Domain.Data.Entities
{
    public abstract class Member : Item
    {
        private string _name = string.Empty;
        public required string Name
        {
            get => _name;
            set { _name = value; InvokeNotify(); }
        }
    }
}