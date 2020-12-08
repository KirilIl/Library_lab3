using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Entities.FileAggregate
{
    public enum FileType
    {
        PDF = 1,
        WORD = 2
    }
    public class File
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public FileType Type { get; set; }
        public byte[] FileInBytes { get; set; }
    }
}
