﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Data.Repositories
{
    public interface IFileRepository
    {
        byte[] GetFile(int bookId);
    }
}
