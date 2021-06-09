using System;
using ConsoleZipper.Core;
using ConsoleZipper.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleZipper
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.RegisterServices();
            var serviceProvider = services.BuildServiceProvider();
            var app = serviceProvider.GetService<Starter>();
            try
            {
                app?.Run(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
