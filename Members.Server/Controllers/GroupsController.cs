using Microsoft.AspNetCore.Mvc;
using Members.Core.Repositories;
using Members.Domain.Data.Entities;
using Members.Server.Extensions;

namespace Members.Server.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private IUnitOfWorkAsync UnitOfWork { get; }

        public GroupsController( IUnitOfWorkAsync unitOfWork )
        {
            UnitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Shared.Group>> GetAsync()
        {
            if ( ! User.HasScope( "Members.Read" ) )
            {
                throw new UnauthorizedAccessException();
            }

            var groups = await UnitOfWork.GetRepositoryAsync<Group>().GetAllAsync();

            return groups.Select( x => new Shared.Group( x.Id, x.Name ) { 
                Members = x.Members?.Select( y => y.Map() ).ToList() ?? new List<Shared.Person>()
            } );
        }

        [HttpGet( "{id}" )]
        public async Task<Shared.Group?> GetAsync( int id )
        {
            var group = await UnitOfWork.GetRepositoryAsync<Group>().GetAsync( id );
            return group?.Map();
        }

        [HttpGet( "{id}/Members" )]
        public async Task<IEnumerable<Shared.Person>> GetMembersAsync( int id )
        {
            var group = await UnitOfWork?.GetRepositoryAsync<Group>().GetAsync( id );
            if ( group != null )
            {
                UnitOfWork?.GetRepositoryAsync<Group>().Ensure( group, g => g.Members );
                return group.Members?.Select( y => y.Map() ) ?? Enumerable.Empty<Shared.Person>();
            }
            return Enumerable.Empty<Shared.Person>();
        }
    }
}
