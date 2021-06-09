using System;
using System.IO;
using System.IO.Compression;
using ConsoleZipper.Factory.Interfaces;

namespace ConsoleZipper.Factory.Concrete
{
    public class LocalOutput : IOutput
    {
        public void OutputFile(DirectoryInfo tempDirectory, string targetFileName, string optionalParam)
        {
            var outputPath = GetOutPutPath(optionalParam, targetFileName);
            CreateZipFile(tempDirectory.FullName, outputPath);

            try
            {
                tempDirectory.Delete(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        private string GetOutPutPath(string optionalParam, string targetFileName)
        {
            return $"{optionalParam}\\{targetFileName}";
        }

        private void CreateZipFile(string tempDirectory, string outputPath)
        {
            try
            {
                ZipFile.CreateFromDirectory(tempDirectory, outputPath, CompressionLevel.Optimal, false);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unable to perform the operation. {e.Message}");
            }
        }
    }
}
