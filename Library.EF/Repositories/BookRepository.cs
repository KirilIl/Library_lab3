using Library.Data.Entities.BookAggregate;
using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EF.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public Book GetBook(string name, int authorId)
        {
            return _context.Books.FirstOrDefault(x => x.Name == name && x.AuthorId == authorId);
        }

        public Book GetBookByQuote(string quote)
        {
            return _context.Books.FirstOrDefault(x => x.Quotes.Contains(_context.Quotes.FirstOrDefault(x => x.QuoteString == quote)));
        }

        public IEnumerable<Book> GetBooks(char firstLetter)
        {
            var debug  = _context.Books.Where(x => x.FirstLetter == firstLetter); 
            return _context.Books.Where(x => x.FirstLetter == firstLetter);
        }

        public IEnumerable<Book> GetBooks(string name)
        {
            return _context.Books.Where(x => x.Name == name);
        }

        public async Task IncrementDownloadedTimes(int bookId)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == bookId);
            book.DownloadedTimes++;
            await _context.SaveChangesAsync();
        }
    }
}
