using BusinessLayer.interfaces;
using BusinessLayer.services;
using BusinessLayer.validators;
using DAL.layers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
namespace DuelSysDesktop
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; } = CreateServices();

        private static IServiceProvider CreateServices()
        {
            return new HostBuilder().ConfigureServices(services =>
            {
                services.AddSingleton<IDALUser, DALUser>();
                services.AddSingleton<IDALTournament, DALTournament>();
                services.AddSingleton<IDALMatch, DALMatch>();

                services.AddSingleton<TournamentScheduler>();
                services.AddSingleton<UserValidator>();
                services.AddSingleton<TournamentValidator>();
                services.AddSingleton<MatchValidator>();

                services.AddScoped<UserService>();
                services.AddScoped<MatchService>();
                services.AddScoped<TournamentService>();

            }).Build()
            .Services;
        }

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}