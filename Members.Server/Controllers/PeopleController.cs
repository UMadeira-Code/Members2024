using Members.Core.Repositories;
using Members.Domain.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace Members.Server.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    //[Authorize]
    public class PeopleController : ControllerBase
    {
        private IRepositoryAsync<Person> Repository{ get; }

        public PeopleController( IUnitOfWorkAsync unitOfWork )
        {
            Repository = unitOfWork.GetRepositoryAsync<Person>();
        }

        [HttpGet]
        [RequiredScope( "AzureAd:Scopes" )]
        public IEnumerable<Shared.Person>? Get()
        {
            return Repository.GetAll().Select( x => x.Map() );
        }

        //[HttpGet]
        //[RequiredScope( "AzureAd:Scopes" )]
        //public async Task<IActionResult>? GetAsync()
        //{
        //    try
        //    {
        //        var people = await Repository.GetAllAsync();
        //        return Ok( people.Select( x => x.Map() ) );
        //    }
        //    catch ( Exception ex )
        //    {
        //        return StatusCode( StatusCodes.Status500InternalServerError, ex.Message );
        //    }
        //}

        [HttpGet( "{id}" )]
        [RequiredScope( "AzureAd:Scopes" )]
        public Shared.Person? Get( int id )
        {
            var person = Repository.Get( id );
            return person?.Map() ?? null;
        }
    }
}
