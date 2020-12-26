using Library.Data.Entities.FileAggregate;
using System.Collections.Generic;

// поправить агрегаты
namespace Library.Data.Entities.BookAggregate
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
