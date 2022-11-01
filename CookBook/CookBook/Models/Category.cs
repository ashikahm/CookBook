using System;
using System.Collections.Generic;
using System.Text;

namespace CookBook.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
        public string CategoryPoster { get; set; }
    }
}
