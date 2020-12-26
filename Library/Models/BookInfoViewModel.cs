using Library.Data.Entities.FileAggregate;

namespace Library.Models
{
    public class BookInfoViewModel
    {
        public  string Name { get; set; }
        public string AuthorName { get; set; }
        public long DownloadedTimes { get; set; }
        public FileType Types { get; set; }
    }
}
