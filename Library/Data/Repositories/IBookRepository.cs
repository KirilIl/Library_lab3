using Library.Data.Entities.BookAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks(char firstLetter);
        IEnumerable<Book> GetBooks(string name);
    }
}
