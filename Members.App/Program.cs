using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using Members.Core.Data;
using Members.Shared.Data;

namespace Members.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddDbContext<MembersContext>( 
                options => options.UseSqlServer( config.GetConnectionString( "Members" ) ) );
            services.AddSingleton<IFactory>( sp => new Factory( typeof( Person ), typeof( Group ) ) );
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddTransient<MainForm>();
            var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetService<MainForm>();
            Application.Run( form );
        }
    }
}