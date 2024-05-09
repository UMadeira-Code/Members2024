using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Members.Shared;
using System.Diagnostics;


namespace Members.Client.Pages
{
    public partial class Home
    {
        private string BearerToken { get; set; } = string.Empty;

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
                BearerToken = token.Value;
            }

            var valid = ! string.IsNullOrWhiteSpace( BearerToken );
            Debug.Assert( !string.IsNullOrWhiteSpace( BearerToken ) );
            Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", BearerToken );
            people = await Http.GetFromJsonAsync<Person[ ]>( "https://localhost:7204/api/People" );
            
            groups = await Http.GetFromJsonAsync<Group[ ]>( "https://localhost:7204/api/Groups" );
            foreach ( var group in groups   )
            {
                var members = await GetMembersAsync( group );
                group.Members = members.ToArray();
            }
        }

        private IEnumerable<Person> GetMembers( Group group )
        {
            var members = GetMembersAsync( group )?.Result;
            Debug.Assert( members != null );
            return members;
        }

        private async Task<IEnumerable<Person>> GetMembersAsync( Group group )
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( BearerToken ) );
            Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", BearerToken );
            var members = await Http.GetFromJsonAsync<Person[]>(
                $"https://localhost:7204/api/Groups/{group.Id}/Members" );
            return members ?? Array.Empty<Person>();
        }
    }
}
