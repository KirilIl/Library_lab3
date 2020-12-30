using AutoMapper;
using Library.Data.Entities.FileAggregate;
using Library.Data.Repositories;
using Library.Domain.Interfaces;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IAuthorRepository _authorRepository;
        public BookController(IBookService bookService, IAuthorRepository authorRepository)
        {
            _bookService = bookService;
            _authorRepository = authorRepository;
        }

        public IActionResult GetBooks(char letter)
        {
            var books = _bookService.GetBooks(letter);
            return View("Books", books);
        }

        public IActionResult GetBooksByNameOrAuthor(string name)
        {
            var books = _bookService.GetBooks(name);

            if(books == null)
            {
                return View("BookNotFound");
            }
            return View("Books", books);
        }

        public IActionResult GetBook(string name, int authorid)
        {
            var book = _bookService.GetBook(name, authorid);
            return View("BookInfo", _bookService.GetBookInfo(book));
        }

        public IActionResult GetBookByQuote(string quote)
        {
            var book = _bookService.GetBookByQuote(quote);
            return View("BookInfo", _bookService.GetBookInfo(book));
        }

        public IActionResult Download(string name, string authorname, FileType fileType)
        {
            
            var book = _bookService.GetBook(name, _authorRepository.GetAuthor(authorname).Id);
            var file = _bookService.DownloadBook(book, fileType);
            if (file == null)
            {
                return View("FileNotFound");
            }
            var mimeType = string.Empty;
            if (fileType == FileType.PDF)
            {
                   mimeType = "application/pdf";
            }
            else if (fileType == FileType.WORD)
            {
                    mimeType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
            }
            return new FileStreamResult(file, mimeType);
        }
    }
}
