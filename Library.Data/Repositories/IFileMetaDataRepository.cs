using Library.Data.Entities.FileAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
   public interface IFileMetaDataRepository
    {
       IEnumerable<FileType> GetFileTypes(int bookId);
    }
}
