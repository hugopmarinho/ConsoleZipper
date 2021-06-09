using ConsoleZipper.Core.Entities.Interfaces;

namespace ConsoleZipper.Core.Interfaces
{
    public interface IServiceStarter
    {
        void Run(string[] args);
        void StartAsync(CommandLineOptions options);
    }
}
