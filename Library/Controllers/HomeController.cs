using Library.Domain.Interfaces;
using Library.EF;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuoteService _quoteService;
        private readonly IBookService _bookService;
        public HomeController(IQuoteService quoteService, IBookService bookService)
        {
            _quoteService = quoteService;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
             ViewData["Quote"] = _quoteService.GetRandomQuote().QuoteString;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
