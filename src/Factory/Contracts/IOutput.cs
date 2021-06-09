using System.IO;

namespace ConsoleZipper.Factory.Interfaces
{
    public interface IOutput
    {
        void OutputFile(DirectoryInfo tempDirectory, string targetFileName, string optionalParam);

    }
}
