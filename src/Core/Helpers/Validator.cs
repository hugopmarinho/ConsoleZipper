using System.Collections.Generic;
using System.IO;
using System.Linq;
using ConsoleZipper.Core.Interfaces;

namespace ConsoleZipper.Core.Helpers
{
    public class Validator : IValidator
    {
        public bool FileNameIsValid(IEnumerable<string> excludedFiles, string fileName)
        {
            return excludedFiles != null && !excludedFiles.Contains(Path.GetFileNameWithoutExtension(fileName));
        }

        public bool FileExtensionIsValid(IEnumerable<string> excludedExtensions, string fileName)
        {
            return excludedExtensions != null && !excludedExtensions.Contains(Path.GetFileName(fileName).Remove(0, Path.GetFileNameWithoutExtension(fileName).Length));
        }

        public bool FolderIsExcluded(IEnumerable<string> excludedFolders, string folderName)
        {
            return excludedFolders != null && excludedFolders.Contains(folderName);
        }
    }
}
