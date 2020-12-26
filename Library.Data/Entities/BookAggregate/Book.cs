using Library.Data.Entities.QuoteAggregate;
using System.Collections.Generic;

// добавить логику с кнопкой скачиваний типа книги
namespace Library.Data.Entities.BookAggregate
{
    public class Book
    {
        public int Id { get; set; }
        public char FirstLetter { get; set; }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public long DownloadedTimes {get;set;}
        public ICollection<Quote> Quotes { get; set; }
    }
}
