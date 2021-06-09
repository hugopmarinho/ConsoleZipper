using System.Collections.Generic;

namespace ConsoleZipper.Core.Interfaces
{
    public interface IValidator
    {
        bool FileNameIsValid(IEnumerable<string> excludedFiles, string fileName);
        bool FileExtensionIsValid(IEnumerable<string> excludedExtensions, string fileName);
        bool FolderIsExcluded(IEnumerable<string> excludedFolders, string folderName);
    }
}
