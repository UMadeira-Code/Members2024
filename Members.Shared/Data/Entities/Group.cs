namespace Members.Shared.Data.Entities
{
    public class Group : Member
    {
        public ICollection<Person> Members { get; set; } = new List<Person>();
    }
}
