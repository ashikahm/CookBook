using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CookBook.Models
{
    public class RecipeList
    {
        public int CategoryId { get; set; }
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public double Calories { get; set; }
        public string RecipeKind { get; set; }
        public int CookTime { get; set; }
        public int PrepTime { get; set; }
        public int NumberOfServing { get; set; }
        public List<string> IngredientsRequired { get; set; }
        public List<string> Directions { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }
        public int likes { get; set; }
    }
}
