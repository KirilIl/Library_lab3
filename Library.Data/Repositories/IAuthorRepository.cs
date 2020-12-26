using Library.Data.Entities.BookAggregate;
using System.Collections.Generic;

namespace Library.Data.Repositories
{
    public interface IAuthorRepository
    {
        IEnumerable<Book> GetBooks(string authorName);
        Author GetAuthor(int id);
        Author GetAuthor(string name);
    }
}
