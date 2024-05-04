using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Identity.Web;
using Microsoft.IdentityModel.Logging;

namespace Members
{
    public class Program
    {
        public static void Main( string[ ] args )
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services
                .AddAuthentication( JwtBearerDefaults.AuthenticationScheme )
                .AddMicrosoftIdentityWebApi( builder.Configuration.GetSection( "AzureAd" ) );

            builder.Services.AddCors( options => {
                options.AddPolicy( name: "MembersCorsPolicy",
                    policy => {
                        policy.WithOrigins( "https://localhost:7204" ); // Members2024
                    } );
                options.AddPolicy( name: "AllowEveryonePolicy",
                    policy => {
                        policy.AllowAnyOrigin()
                              .AllowAnyHeader()
                              .AllowAnyMethod();
                    } );
            } );
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if ( app.Environment.IsDevelopment() )
            {
                app.UseWebAssemblyDebugging();

                app.UseSwagger();
                app.UseSwaggerUI();
            }
            else
            {
                app.UseExceptionHandler( "/Error" );
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseCors( "AllowEveryonePolicy" );
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapRazorPages();
            app.MapControllers();
            app.MapFallbackToFile( "index.html" );

            IdentityModelEventSource.ShowPII = true;
            IdentityModelEventSource.LogCompleteSecurityArtifact = true;

            app.Run();
        }
    }
}
