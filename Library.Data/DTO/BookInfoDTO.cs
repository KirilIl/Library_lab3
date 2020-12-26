using Library.Data.Entities.FileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.DTO
{
    public record BookInfoDTO
           (string Name,
            string AuthorName,
            long DownloadedTimes,
            FileType Types);
}
