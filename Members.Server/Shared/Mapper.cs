
using Entities = Members.Domain.Data.Entities;

namespace Members.Server
{
    public static class Mapper
    {
        public static Shared.Person Map( this Entities.Person self )
        {
            return new Shared.Person( self.Id, self.Name );
        }

        public static Shared.Group Map( this Entities.Group self )
        {
            return new Shared.Group( self.Id, self.Name );
        }
    }
}
