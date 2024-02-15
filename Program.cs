using Exportar_XML.Repository;
using Exportar_XML.Services;
using Exportar_XML.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows.Forms.Design;

namespace Exportar_XML
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

            var services = new ServiceCollection();
            configureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {

                var FrUsers = serviceProvider.GetRequiredService<FrUsers>();
                Application.Run(FrUsers);
            }
        }

        private static void configureServices(ServiceCollection services)
        {
            //Services

            services.AddScoped<IClientService, ClientService>()
                    .AddScoped<FrUsers>()
                    .AddScoped<IDatabaseService, DataBaseService>()
                    .AddScoped<IRepository, ClientRepository>()
                    .AddScoped<IEventos, EventosService>()
                    .AddScoped<IValidators, Validator>();

            //Connection DB

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;

            services.AddSingleton(connectionString);



        }
    }

    
}