using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuoteApp.Helpers;
using QuoteApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(ListOfQuotes.Quoets);
        }

        [HttpGet]
        public ViewResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddAuthor(AddAuthorModel quoteDetail)
        {
            ListOfQuotes.Add(quoteDetail);
            return View("Done", quoteDetail);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
