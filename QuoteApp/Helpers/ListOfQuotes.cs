using QuoteApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteApp.Helpers
{
    public class ListOfQuotes
    {
        public static List<AddAuthorModel> quotes = new List<AddAuthorModel>()
        {
            new AddAuthorModel()
            {
                Quote = "Na God dey bring Customer o!",
                Author = "An Okpa Seller somewhere in Golf city Junction, 2021."
            },
            new AddAuthorModel()
            {
                Quote = "The Gorrila died from a handshake",
                Author = "Sage, 2021."
            },
            new AddAuthorModel()
            {
                Quote = "We Will Not Bow",
                Author = "Daniel Chapter 3"
            }
        };              
        
        public static IEnumerable<AddAuthorModel> Quoets => quotes;
        public static void Add(AddAuthorModel quote)
        {
            quotes.Add(quote);
        }
    }
}
