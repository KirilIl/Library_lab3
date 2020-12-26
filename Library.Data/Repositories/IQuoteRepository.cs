using Library.Data.Entities.BookAggregate;
using Library.Data.Entities.QuoteAggregate;

namespace Library.Data.Repositories
{
   public interface IQuoteRepository
    {
        Quote GetRandomQuote();
    }
}
