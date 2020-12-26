using Library.Data.Entities.BookAggregate;
using Library.Data.Entities.QuoteAggregate;
using Library.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EF.Repositories
{
    public class QuoteRepository : IQuoteRepository
    {
        private readonly LibraryContext _context;
        public QuoteRepository(LibraryContext context)
        {
            _context = context;
        }
        public Quote GetRandomQuote()
        {
            var quotes = _context.Quotes.AsEnumerable();
            var rand = new Random().Next(1, quotes.Count() + 1);
            return quotes.FirstOrDefault(x => x.BookId == rand);
        }
    }
}
