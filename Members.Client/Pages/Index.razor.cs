


using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Members.Shared;
using System.Diagnostics;

namespace Members.Client.Pages
{
    public partial class Index
    {
        //public Index()
        //{
        //}

        //public Index( HttpClient http, IAccessTokenProvider accessTokenProvider )
        //{
        //    Http = http;    
        //    TokenProvider = accessTokenProvider;
        //}

        //private HttpClient           Http { get; }
        //private IAccessTokenProvider TokenProvider { get; }

        private  Group[]? groups = Array.Empty<Group>();
        private Person[]? people = Array.Empty<Person>();

        protected override async Task OnInitializedAsync()
        {
            var result = await TokenProvider.RequestAccessToken(
                new AccessTokenRequestOptions {
                    Scopes = new[] { 
                        "api://e4e16625-e73c-4d86-b262-c9d9936ed0be/Members.Read"
                    }
            });

            if ( result.TryGetToken( out var token ) )
            {
                Http.DefaultRequestHeaders.Authorization = 
                    new AuthenticationHeaderValue( "Bearer", token.Value );

                people = await Http.GetFromJsonAsync<Person[]>( "https://localhost:7204/api/People" );
                groups = await Http.GetFromJsonAsync<Group[ ]>( "https://localhost:7204/api/Groups" );
            }
        }

        private IEnumerable<Person> GetMembers( Group group )
        {
            var members = Enumerable.Empty<Person>();
            Task.Run( async () => await GetMembersAsync( group ) )
                .ContinueWith( task => members = task?.Result );
            return members;
        }

        private async Task<IEnumerable<Person>> GetMembersAsync( Group group )
        {
            var result = await TokenProvider.RequestAccessToken(
                new AccessTokenRequestOptions {
                    Scopes = new[] {
                        "api://e4e16625-e73c-4d86-b262-c9d9936ed0be/Members.Read"
                    }
                });

            if ( result.TryGetToken( out var token ) )
            {
                Http.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue( "Bearer", token.Value );

                var members = await Http.GetFromJsonAsync<Person[]>(
                    $"https://localhost:7204/api/Groups/{group.Id}/Members" );
                return members ?? Array.Empty<Person>();
            }
            return Array.Empty<Person>();
        }
    }
}
