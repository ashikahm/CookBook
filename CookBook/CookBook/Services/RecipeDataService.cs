using CookBook.Models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class RecipeDataService
    {
        FirebaseClient client;
        public RecipeDataService()
        {
            client = new FirebaseClient("https://cookbook-528e5-default-rtdb.firebaseio.com/");
        }
        public async Task<List<RecipeList>> GetRecipesAsync()
        {
            var recipelist = (await client.Child("RecipeList")
                .OnceAsync<RecipeList>())
                .Select(f => new RecipeList
                {
                    Calories = f.Object.Calories,
                    CategoryId = f.Object.CategoryId,
                    CookTime = f.Object.CookTime,
                    Directions = f.Object.Directions,
                    ImageUrl = f.Object.ImageUrl,
                    IngredientsRequired = f.Object.IngredientsRequired,
                    likes = f.Object.likes,
                    NumberOfServing = f.Object.NumberOfServing,
                    PrepTime= f.Object.PrepTime,
                    Rating = f.Object.Rating,
                    RecipeId = f.Object.RecipeId,
                    RecipeName = f.Object.RecipeName,
                    RecipeKind = f.Object.RecipeKind
                    
                }).ToList();
            return recipelist;
        }
        public async Task<ObservableCollection<RecipeList>> GetRecipeByCategory(int catId)
        {
            var RecipeMenuList = new ObservableCollection<RecipeList>();    
            var items = (await GetRecipesAsync()).Where(p=>p.CategoryId==catId).ToList();
            foreach(var item in items)
            {
                RecipeMenuList.Add(item);
            }
            return RecipeMenuList;
        }
        public async Task<ObservableCollection<RecipeList>> GetLatestRecipeAsync()
        {
            var latest = new ObservableCollection<RecipeList>();
            var items = (await GetRecipesAsync()).OrderByDescending(f => f.RecipeId).Take(10);
            foreach (var item in items)
            {
                latest.Add(item);
            }
            return latest;
        }
    }
}
