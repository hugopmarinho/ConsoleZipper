using System.Collections.Generic;
using CommandLine;

namespace ConsoleZipper.Core.Entities.Interfaces
{
    public class CommandLineOptions : ICommandLineOptions
    {
        [Option(shortName: 's', longName: "sourceFolder", Required = true, HelpText = "Path to source folder.")]
        public string Source { get; set; }

        [Option(shortName: 'n', longName: "fileName", Required = true, HelpText = "Name of the resulting file.")]
        public string FileName { get; set; }

        [Option(shortName: 'e', longName: "extensions", Required = false, HelpText = "File extensions to be excluded.")]
        public IEnumerable<string> ExcludedExtensions { get; set; }

        [Option(shortName: 'd', longName: "dirs", Required = false, HelpText = "Directories to be excluded.")]
        public IEnumerable<string> ExcludedDirs { get; set; }

        [Option(shortName: 'f', longName: "files", Required = false, HelpText = "File names to be excluded.")]
        public IEnumerable<string> ExcludedFiles { get; set; }

        [Option(shortName: 'o', longName: "output", Required = true, HelpText = "Output type.")]
        public string OutputType { get; set; }

        [Option(shortName: 'p', longName: "param", Required = true, HelpText = "Optional parameter for the chosen output", Default = "")]
        public string OptionalParam { get; set; }
    }
}
