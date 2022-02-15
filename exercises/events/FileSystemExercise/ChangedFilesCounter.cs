using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemExercise
{
    public class ChangedFilesCounter
    {
        private readonly HashSet<string> _files;

        public int ChangeCount => _files.Count;

        private readonly IFileSystem _fileSystem;
        public ChangedFilesCounter(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
            _fileSystem.FileCreated += AddFile;
            _fileSystem.FileDeleted += AddFile;
            _fileSystem.FileWritten += AddFile;
        }

        private void AddFile(string name)
        {
            _files.Add(name);
        }

    }
}
