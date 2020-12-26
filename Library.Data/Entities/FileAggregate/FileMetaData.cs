using System;

namespace Library.Data.Entities.FileAggregate
{
    [Flags]
    public enum FileType
    {
        None = 0,
        PDF = 1,
        WORD = 2
    }
    public class FileMetaData
    {
        public int BookId { get; set; }
        public FileType Type { get; set; }
    }  
}
