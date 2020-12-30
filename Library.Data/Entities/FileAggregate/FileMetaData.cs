using System;

namespace Library.Data.Entities.FileAggregate
{
    public enum FileType
    {
        PDF = 1,
        WORD = 2
    }
    public class FileMetaData
    {
        public int BookId { get; set; }
        public FileType Type { get; set; }
    }  
}
