using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Members.Shared;
using System.Diagnostics;
using MudBlazor;
using Members.Core.Observables;
using System.Data.Common;
using Members.Core.Commands;
using Microsoft.AspNetCore.Components.Web;
using Members.Client.Shared;
using Members.Shared.Commands;


namespace Members.Client.Pages
{
    public partial class Home : IObservable
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

            await LoadDataAsync();

            this.Notify += ( s, a ) => {
                //var id = _selectedPersonId;
                var changed = HasSelection;
                StateHasChanged();
            };
        }

        private async Task LoadDataAsync()
        {
            Debug.Assert( !string.IsNullOrWhiteSpace( BearerToken ) );
            Http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( "Bearer", BearerToken );
            people = await Http.GetFromJsonAsync<Person[ ]>( "https://localhost:7204/api/People" );

            groups = await Http.GetFromJsonAsync<Group[ ]>( "https://localhost:7204/api/Groups" );
            foreach ( var group in groups )
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

        #region Observable
        public event EventHandler? Notify;

        private void InvokeNotify( EventArgs? args = null )
        {
            Notify?.Invoke( this, args ?? EventArgs.Empty );
        }
        #endregion

        private string _selectedPersonId = string.Empty;
        private string SelectedPersonId
        {
            get => _selectedPersonId;
            set { _selectedPersonId = value; HasSelection = ! string.IsNullOrEmpty( value ); }
        }

        private bool HasSelection { get; set; }

        private async Task OnEdit() 
        {
            if ( int.TryParse( SelectedPersonId, out int id ) )
            {
                var person = people?.FirstOrDefault( e => e.Id == id );
                if ( person == null ) return;

                var parameters = new DialogParameters<PromptDialog> {
                    { x => x.Title, "Change Person's Name Dialog" },
                    { x => x.Label, "Person's Name" },
                    { x => x.Value, person.Name     }
                };

                var options = new DialogOptions { CloseOnEscapeKey = true };
                var dialog = await DialogService.ShowAsync<PromptDialog>( "Change Name", parameters, options );
                var result = await dialog.Result;

                if ( ! result.Canceled )
                { 
                    var label = result.Data.ToString() ?? string.Empty;
                    Executor.Execute( new RenameCommand( person, label ) );
                }
            }
        }

        private async Task OnDelete( MouseEventArgs e )
        {
            SelectedPersonId = string.Empty;
        }
    }
}
