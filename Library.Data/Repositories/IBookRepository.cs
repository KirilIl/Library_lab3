using Library.Data.Entities.BookAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks(char firstLetter);
        IEnumerable<Book> GetBooks(string name);
        Book GetBook(string name, int authorId);
        Book GetBookByQuote(string quote);
        Task IncrementDownloadedTimes(int bookId);
    }
}
