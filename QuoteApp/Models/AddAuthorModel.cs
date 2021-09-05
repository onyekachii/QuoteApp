using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuoteApp.Models
{
    public class AddAuthorModel
    {
        public string Author { get; set; } = "Anonymous";

        [Required(ErrorMessage = "Please enter a Quote")]
        public string Quote { get; set; }
        
    }
}
