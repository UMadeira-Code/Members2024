namespace Members.Shared
{
    public class Group : Member
    {
        public Group( int  id, string name ) : base( id, name ) { }

        public ICollection<Person> Members { get; set; } = new List<Person>();
    }
}
