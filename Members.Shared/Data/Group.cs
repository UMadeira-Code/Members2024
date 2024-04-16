namespace Members.Shared.Data
{
    public class Group : Member
    {
        public virtual IList<Person> Members { get; set; } = new List<Person>();
    }
}
