using CookBook.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class CategoryDataService
    {
        FirebaseClient client;
        public CategoryDataService()
        {
            client = new FirebaseClient("https://cookbook-528e5-default-rtdb.firebaseio.com/");
        }
        public async Task<List<Category>> GetCategories()
        {
            var category = (await client.Child("Category")
                .OnceAsync<Category>())
                .Select(p => new Category()
                {
                    CategoryId=p.Object.CategoryId,
                    CategoryName=p.Object.CategoryName,
                    CategoryPoster=p.Object.CategoryPoster,
                    ImageUrl= p.Object.ImageUrl

                }).ToList();
            Console.WriteLine(category);
            return category;
        }
    }
}
