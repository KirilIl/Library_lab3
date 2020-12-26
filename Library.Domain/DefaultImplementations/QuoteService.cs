using Library.Data.Entities.BookAggregate;
using Library.Data.Entities.QuoteAggregate;
using Library.Data.Repositories;
using Library.Domain.Interfaces;

namespace Library.Domain.DefaultImplementations
{
    public class QuoteService : IQuoteService
    {
        private readonly IQuoteRepository _quoteRepository;

        public QuoteService(IQuoteRepository quoteRepository)
        {
            _quoteRepository = quoteRepository;
        }

        public Quote GetRandomQuote()
        {
            return _quoteRepository.GetRandomQuote();
        }
    }
}
