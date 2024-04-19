using Members.Core.Data;

namespace Members.Shared.Data.Entities
{
    public abstract class Member : Item
    {
        public required string Name { get; set; }
    }
}
