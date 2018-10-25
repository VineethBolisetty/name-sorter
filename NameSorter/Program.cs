using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NameSorter.Business.Implementations;
using NameSorter.Business.Interfaces;
using NameSorter.Services.Implementations;
using NameSorter.Services.Interfaces;

namespace NameSorter
{
    /// <summary>
    /// The class with the entry point method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                args = new string[] { "../unsorted-names-list.txt" };
            }
            else
            {
                // Validate the input arguments
                ValidateArguments(args);
            }
            // Initialise the application dependencies
            var serviceProvider = Init();
            // Run the application
            serviceProvider.GetService<IApp>().Run(args[0], "sorted-names-list.txt");
        }

        /// <summary>
        /// Validates the command-line arguments.
        /// </summary>
        /// <param name="args">Arguments.</param>
        static void ValidateArguments(string[] args)
        {
            if(!args.Any())
            {
                Console.WriteLine("Invalid Usage");
                Console.WriteLine($"{AppDomain.CurrentDomain.FriendlyName} path-to-txt-file-with-names");
            }
        }

        /// <summary>
        /// Initialise the services or configuration
        /// </summary>
        /// <returns>The init.</returns>
        static IServiceProvider Init()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            return services.BuildServiceProvider();
        }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">Services.</param>
        static void ConfigureServices(ServiceCollection services)
        {
            services
                .AddSingleton<ILoggerFactory, LoggerFactory>()
                .AddLogging()
                .AddScoped<IConsoleService, ConsoleService>()
                .AddScoped<ITextFileService, TextFileService>()
                .AddTransient<IApp, App>();
        }
    }
}