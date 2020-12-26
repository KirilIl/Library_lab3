using Library.Data.Entities.BookAggregate;
using Library.Data.Entities.QuoteAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Interfaces
{
    public interface IQuoteService
    {
        Quote GetRandomQuote();
    }
}
