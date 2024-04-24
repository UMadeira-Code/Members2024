using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using Members.Core.Repositories;
using Members.Shared.Data;
using Members.Shared.Data.Entities;
using Members.Core.Commands;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var config = new ConfigurationBuilder()
                .SetBasePath( Directory.GetCurrentDirectory() )
                .AddJsonFile("appsettings.json")
                .Build();

            var types = new [] { typeof( Person ), typeof( Group ) };

            var services = new ServiceCollection();
            services.AddDbContext<DbContext,MembersContext>( 
                options => options.UseSqlServer( config.GetConnectionString( "Members" ) ) );
            services.AddSingleton<IFactory>( sp => new Factory( types ) );
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IUnitOfWorkAsync, UnitOfWorkAsync>();
            services.AddSingleton<IExecutor, ObservableExecutor>();
            services.AddTransient<MainForm>();
            var serviceProvider = services.BuildServiceProvider();

            var form = serviceProvider.GetService<MainForm>();
            Application.Run( form );
        }
    }
}