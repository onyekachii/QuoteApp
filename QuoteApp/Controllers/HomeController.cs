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
            List<AddAuthorModel> q = ListOfQuotes.quotes;            
            Random rand = new Random();
            var randomNumber = rand.Next(0, q.Count());
            var qoute = q[randomNumber];
            return View(qoute);
        }

        [HttpGet]
        public ViewResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddAuthor(AddAuthorModel quoteDetail)
        {
            if (ModelState.IsValid)
            {
                ListOfQuotes.Add(quoteDetail);
                return View("Done", quoteDetail);
            }
            return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }        
    }
}
