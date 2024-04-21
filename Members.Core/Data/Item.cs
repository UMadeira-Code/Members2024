using Members.Core.Observables;

namespace Members.Core.Data
{
    public abstract class Item : Observable
    {
        public int     Id        { get; set; }
        public bool    Zombie    { get; set; } = false;
        public byte[]? TimeStamp { get; set; }
    }
}
