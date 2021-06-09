using System.Collections.Generic;

namespace ConsoleZipper.Core.Entities.Interfaces
{
    public interface ICommandLineOptions
    {
        string Source { get; set; }
        string FileName { get; set; }
        IEnumerable<string> ExcludedExtensions { get; set; }
        IEnumerable<string> ExcludedDirs { get; set; }
        IEnumerable<string> ExcludedFiles { get; set; }
        string OutputType { get; set; }
        string OptionalParam { get; set; }
    }
}