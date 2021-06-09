using CommandLine;
using ConsoleZipper.Core.Interfaces;
using ConsoleZipper.Core.Entities.Interfaces;

namespace ConsoleZipper.Core
{
    public class Starter : IServiceStarter
    {
        private readonly IProcessor _processor;
        public Starter(IProcessor processor)
        {
            _processor = processor;
        }
        public void Run(string[] args)
        {
            Parser.Default.ParseArguments<CommandLineOptions>(args)
                .WithParsed(StartAsync);
        }

        public void StartAsync(CommandLineOptions options)
        {
            _processor.Process(options);
        }
    }
}
