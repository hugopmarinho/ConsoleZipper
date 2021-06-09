using ConsoleZipper.Core.Entities.Interfaces;

namespace ConsoleZipper.Core.Interfaces
{
    public interface IProcessor
    {
        void Process(CommandLineOptions opt);
    }
}
