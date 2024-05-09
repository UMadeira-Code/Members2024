using Microsoft.AspNetCore.Mvc;
using Members.Core.Repositories;
using Members.Domain.Data.Entities;
using Members.Server.Extensions;
using Microsoft.Identity.Web.Resource;
using Microsoft.AspNetCore.Authorization;

namespace Members.Server.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    //[Authorize]
    public class GroupsController : ControllerBase
    {
        private IRepositoryAsync<Group> Repository { get; }

        public GroupsController( IUnitOfWorkAsync unitOfWork )
        {
            Repository = unitOfWork.GetRepositoryAsync<Group>();
        }

        [HttpGet]
        [RequiredScope( "AzureAd:Scopes" )]
        public async Task<IEnumerable<Shared.Group>> GetAsync()
        {
            var groups = await Repository.GetAllAsync();

            return groups.Select( x => new Shared.Group( x.Id, x.Name ) { 
                Members = x.Members?.Select( y => y.Map() ).ToList() ?? new List<Shared.Person>()
            } );
        }

        [HttpGet( "{id}" )]
        [RequiredScope( "AzureAd:Scopes" )]
        public async Task<Shared.Group?> GetAsync( int id )
        {
            var group = await Repository.GetAsync( id );
            return group?.Map();
        }

        [HttpGet( "{id}/Members" )]
        public async Task<IEnumerable<Shared.Person>> GetMembersAsync( int id )
        {
            var group = await Repository.GetAsync( id );
            if ( group == null ) return Enumerable.Empty<Shared.Person>();
            
            Repository.Ensure( group, g => g.Members );
            return group.Members?.Select( y => y.Map() ) ?? Enumerable.Empty<Shared.Person>();
        }
    }
}
