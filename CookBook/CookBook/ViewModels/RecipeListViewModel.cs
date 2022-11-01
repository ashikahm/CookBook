using CookBook.Models;
using CookBook.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CookBook.ViewModels
{
    public class RecipeListViewModel
    {
        RecipeDataService rds = new RecipeDataService();
        public Category SelectedCategory { get; set; }
        public ObservableCollection<RecipeList> recipeLists { get; set; }
        public RecipeListViewModel(Category selectedCategory)
        {
            SelectedCategory = selectedCategory;
            recipeLists = new ObservableCollection<RecipeList>();
            GetRecipeByCat();
        }

        private async void GetRecipeByCat()
        {
            var items = await rds.GetRecipeByCategory(SelectedCategory.CategoryId);
            foreach(var item in items)
            {
                recipeLists.Add(item);
            }

        }
    }
}
