using Library.Data.Entities.FileAggregate;
using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EF.Repositories
{
    public class FileMetaDataRepository : IFileMetaDataRepository
    {
        private readonly LibraryContext _context;

        public FileMetaDataRepository(LibraryContext context)
        {
            _context = context;
        }

        public FileType GetFileType(int bookId)
        {
            var type = FileType.None;
            foreach (var file in _context.FilesMetaData.Where(x => x.BookId == bookId))
            {
                switch (file.Type)
                {
                    case FileType.PDF:
                        type = type | FileType.PDF;
                        break;
                    case FileType.WORD:
                        type = type | FileType.WORD;
                        break;
                }
            }
            return type;
        }

        public bool IsFileExists(string name, FileType fileType)
        {
            return _context.FilesMetaData.Any(x => x.BookId == _context.Books.FirstOrDefault(x => x.Name == name).Id && x.Type == fileType);
        }
    }
}
