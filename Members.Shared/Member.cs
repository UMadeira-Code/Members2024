namespace Members.Shared
{
    public class Member
    {
        public Member( int id, string name ) 
        { 
            Id = id; Name = name;
        }

        public int    Id   { get; set; }
        public string Name { get; set; }
    }
}
