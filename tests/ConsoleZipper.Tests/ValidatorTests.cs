using System;
using System.Collections.Generic;
using System.Text;
using ConsoleZipper.Core.Helpers;
using NUnit.Framework;

namespace ConsoleZipper.Tests
{
    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void FileNameIsValidShouldReturnFalse()
        {
            var validator = new Validator();
            var fileName = "file1";
            var excludedFileNames = new string[] {"file1"};


            var result = validator.FileNameIsValid(excludedFileNames, fileName);

            Assert.AreEqual(false,result);
        }

        [Test]
        public void FileNameIsValidShouldReturnTrue()
        {
            var validator = new Validator();
            var fileName = "file1";
            var excludedFileNames = new string[]{};


            var result = validator.FileNameIsValid(excludedFileNames, fileName);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void FileExtensionIsValidShouldReturnTrue()
        {
            var validator = new Validator();
            var fileExtension = ".css";
            var excludedFileExtensions = new string[] { };


            var result = validator.FileExtensionIsValid(excludedFileExtensions, fileExtension);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void FileExtensionIsValidShouldReturnFalse()
        {
            var validator = new Validator();
            var fileExtension = ".css";
            var excludedFileExtensions = new string[] {".css"};


            var result = validator.FileExtensionIsValid(excludedFileExtensions, fileExtension);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void FolderIsExcludedShouldReturnFalse()
        {
            var validator = new Validator();
            var folderName = "folder1";
            var excludedFolders = new string[] { };

            var result = validator.FolderIsExcluded(excludedFolders, folderName);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void FolderIsExcludedShouldReturnTrue()
        {
            var validator = new Validator();
            var folderName = "folder1";
            var excludedFolders = new string[] { "folder1" };

            var result = validator.FolderIsExcluded(excludedFolders, folderName);

            Assert.AreEqual(true, result);
        }
    }
}
