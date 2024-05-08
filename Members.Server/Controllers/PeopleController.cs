using Members.Core.Repositories;
using Members.Domain.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Members.Server.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IUnitOfWork UnitOfWork { get; }

        public PeopleController( IUnitOfWork unitOfWork )
        {
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        public IEnumerable<Shared.Person>? Get()
        {
            return UnitOfWork.GetRepository<Person>()
                .GetAll().Select( x => x.Map() );
        }

        [HttpGet( "{id}" )]
        public Shared.Person? Get( int id )
        {
            var person = UnitOfWork.GetRepository<Person>().Get( id );
            if ( person == null ) return null;

            return person?.Map();
        }
    }
}
