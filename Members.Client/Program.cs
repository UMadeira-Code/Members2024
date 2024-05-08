using Members.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

namespace Members.Client
{
    public class Program
    {
        public static async Task Main( string[ ] args )
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>( "#app" );
            builder.RootComponents.Add<HeadOutlet>( "head::after" );

            builder.Services
                .AddHttpClient( "Members.ServerAPI", 
                    client => client.BaseAddress = new Uri( builder.HostEnvironment.BaseAddress ) )
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

            // Supply HttpClient instances that include access tokens when making requests to the server project
            builder.Services.AddScoped( sp =>
                sp.GetRequiredService<IHttpClientFactory>()
                   .CreateClient( "Members.ServerAPI" ) );

            builder.Services.AddMsalAuthentication( options => {
                builder.Configuration.Bind( "AzureAd", options.ProviderOptions.Authentication );
                builder.Configuration.Bind( "AccessTokenScopes", options.ProviderOptions.DefaultAccessTokenScopes );
            } );

            builder.Services.AddMudServices();

            await builder.Build().RunAsync();
        }
    }
}
