using ConsoleZipper.Core;
using ConsoleZipper.Core.Helpers;
using ConsoleZipper.Core.Interfaces;
using ConsoleZipper.Factory;
using ConsoleZipper.Factory.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleZipper.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IOutputFactory, OutputFactory>();
            services.AddTransient<IProcessor, Processor>();
            services.AddSingleton<IValidator, Validator>();
            services.AddTransient<IHelper, Helper>();

            services.AddSingleton<Starter>();
        }

    }
}
