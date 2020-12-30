using Library.Data.DTO;
using Library.Data.Entities.BookAggregate;
using Library.Data.Entities.FileAggregate;
using Library.Data.Repositories;
using Library.Domain.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Library.Domain.DefaultImplementations
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IFileMetaDataRepository _fileMetaDataRepository;
        private string _projectPath;

        public BookService(IFileMetaDataRepository fileMetaDataRepository, IBookRepository bookRepository, IAuthorRepository authorRepository, string path)
        {
            _fileMetaDataRepository = fileMetaDataRepository;
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _projectPath = path;
        }

        

        public Book GetBook(string name, int authorId)
        {
            return _bookRepository.GetBook(name, authorId);
        }

        public Book GetBookByQuote(string quote)
        {
            return _bookRepository.GetBookByQuote(quote);
        }

        public BookInfoDTO GetBookInfo(Book book)
        {
            var author = _authorRepository.GetAuthor(book.AuthorId);
            var types = _fileMetaDataRepository.GetFileTypes(book.Id);
            return new BookInfoDTO(Name: book.Name, AuthorName: author.FullName, DownloadedTimes: book.DownloadedTimes, Types: types);
        }

        public IEnumerable<Book> GetBooks(char firstLetter)
        {
            return _bookRepository.GetBooks(firstLetter);
        }

        public IEnumerable<Book> GetBooks(string name)
        {
            var book = _bookRepository.GetBooks(name);
            if (book.Count() == 0)
            {
                book = _authorRepository.GetBooks(name);
            }
            return book;
        }


        FileStream IBookService.DownloadBook(Book book, FileType fileType)
        {
            _bookRepository.IncrementDownloadedTimes(book.Id);
            var extension = string.Empty;
            if (fileType == FileType.PDF)
            {
                extension = ".pdf";
            }
            else if (fileType == FileType.WORD)
            {
                extension = ".docx";
            }
            return new FileStream(@$"{_projectPath}\Files\{book.Name}{extension}", FileMode.Open);
        }
    }
}
