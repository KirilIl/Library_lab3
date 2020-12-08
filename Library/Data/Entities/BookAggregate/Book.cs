using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Entities.BookAggregate
{
    public class Book
    {
        public int Id { get; set; }
        public char FirstLetter { get; set; }
        public int AuthorId { get; set; }
        public int FileId { get; set; }
        public string Name { get; set; }
    }
}
