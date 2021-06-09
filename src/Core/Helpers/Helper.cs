using System;
using System.IO;
using ConsoleZipper.Core.Interfaces;

namespace ConsoleZipper.Core.Helpers
{
    public class Helper : IHelper
    {
        public DirectoryInfo GetTemporaryDirectory()
        {
            var tempDirectoryName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            try
            {
                return Directory.CreateDirectory(tempDirectoryName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }
    }
}
