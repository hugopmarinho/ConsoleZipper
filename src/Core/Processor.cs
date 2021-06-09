using System;
using System.IO;
using ConsoleZipper.Core.Interfaces;
using ConsoleZipper.Core.Entities.Interfaces;
using ConsoleZipper.Factory.Interfaces;

namespace ConsoleZipper.Core
{
    public class Processor : IProcessor
    {
        private readonly IValidator _validator;
        private readonly IHelper _helper;
        private readonly IOutputFactory _outputFactory;

        public Processor(IValidator validator, IHelper helper, IOutputFactory outputFactory)
        {
            _validator = validator;
            _helper = helper;
            _outputFactory = outputFactory;
        }

        public void Process(CommandLineOptions opt)
        {
            var tempDirectory = _helper.GetTemporaryDirectory();
            var subDirs = Directory.GetDirectories(opt.Source);
            var rootFiles = Directory.GetFiles(opt.Source, "*.*", SearchOption.TopDirectoryOnly);
            var output = _outputFactory.GetOutput(opt.OutputType);

            foreach (var file in rootFiles)
            {
                if (!_validator.FileNameIsValid(opt.ExcludedFiles, file) || !_validator.FileExtensionIsValid(opt.ExcludedExtensions, file)) continue;
                try
                {
                    File.Copy(file, $"{tempDirectory}\\{Path.GetFileName(file)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }

            foreach (var dir in subDirs)
            {
                var dirname = dir.Remove(0, opt.Source.Length + 1);

                if (_validator.FolderIsExcluded(opt.ExcludedDirs, dirname)) continue;

                var currentDir = tempDirectory.CreateSubdirectory(dirname);
                var currentDirName = currentDir.FullName;

                var files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    if (!_validator.FileNameIsValid(opt.ExcludedFiles, file) || !_validator.FileExtensionIsValid(opt.ExcludedExtensions, file)) continue;
                    try
                    {
                        File.Copy(file, $"{currentDirName}\\{Path.GetFileName(file)}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                }
            }

            output.OutputFile(tempDirectory, opt.FileName, opt.OptionalParam);

        }
    }
}
