using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CookBook.ViewModels
{
    internal class RecipeViewModel
    {
        public RecipeList SelectedRecipe { get; set; }  
        public List<string> Ingredients { get; set; }
        public string CountIngredients { get; set; }
        public string color { get; set; }
        public RecipeViewModel(RecipeList selection)
        {
            SelectedRecipe = selection;
            Ingredients = new List<string>();
            Ingredients = SelectedRecipe.IngredientsRequired;
            CountIngredients = (Ingredients.Count()).ToString() + " Ingredients";
        }
    }
}
