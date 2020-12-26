using Library.Data.DTO;
using Library.Data.Entities.BookAggregate;
using Library.Data.Entities.FileAggregate;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Library.Domain.Interfaces
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks(char firstLetter);
        IEnumerable<Book> GetBooks(string name);
        Book GetBook(string name, int authorId);
        Book GetBookByQuote(string quote);
        FileStreamResult DownloadBook(Book book, FileType fileType);
        BookInfoDTO GetBookInfo(Book book);
    }
}
