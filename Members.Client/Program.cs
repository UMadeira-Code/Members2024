using Members.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace Members.Client
{
    public class Program
    {
        public static async Task Main( string[ ] args )
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>( "#app" );
            builder.RootComponents.Add<HeadOutlet>( "head::after" );

            builder.Services.AddHttpClient( "Members.ServerAPI", client => client.BaseAddress = new Uri( builder.HostEnvironment.BaseAddress ) )
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped( sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient( "Members.ServerAPI" ) );

            //builder.Services.AddMsalAuthentication( options => {
            //    builder.Configuration.Bind( "AzureAd", options.ProviderOptions.Authentication );
            //    options.ProviderOptions.DefaultAccessTokenScopes.Add( "api://api.id.uri/access_as_user" );
            //} );

            builder.Services.AddMsalAuthentication( options => {
                builder.Configuration.Bind( "AzureAd", options.ProviderOptions.Authentication );
                options.ProviderOptions.DefaultAccessTokenScopes.Add( "api://e4e16625-e73c-4d86-b262-c9d9936ed0be/Members.Read" );
                options.ProviderOptions.AdditionalScopesToConsent.Add( "https://graph.microsoft.com/User.Read" );
            } );


            await builder.Build().RunAsync();
        }
    }
}
