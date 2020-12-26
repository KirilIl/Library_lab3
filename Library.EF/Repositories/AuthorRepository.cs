using Library.Data.Entities.BookAggregate;
using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EF.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryContext _context;

        public AuthorRepository(LibraryContext context)
        {
            _context = context;
        }

        public Author GetAuthor(int id)
        {
            return _context.Authors.FirstOrDefault(x=>x.Id == id);
        }

        public Author GetAuthor(string name)
        {
            return _context.Authors.FirstOrDefault(x => x.FullName == name);
        }

        public IEnumerable<Book> GetBooks(string authorName)
        {
            var author = _context.Authors.FirstOrDefault(x => x.FullName == authorName);
            if (author == null)
                return null;
            return _context.Books.Where(x => x.AuthorId == author.Id);
        }
    }
}
