using CookBook.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CookBook.Helpers
{
    public class AddCategoryData
    {
        public List<Category> categories;
        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://cookbook-528e5-default-rtdb.firebaseio.com/");
            categories = new List<Category>()
            {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName= "Pasta Recipes",
                    CategoryPoster="PastaPoster.jpg",
                    ImageUrl="pastaRecipe.jpg"
                },
                new Category()
                {
                    CategoryId= 2,
                    CategoryName="Rice Recipes",
                    CategoryPoster="RicePoster.jpg",
                    ImageUrl="RiceRecipe.jpg"
                },
                new Category()
                {
                    CategoryId=3,
                    CategoryName="Salads",
                    CategoryPoster="SaladPoster.jpg",
                    ImageUrl="SaladRecipe.jpg"
                },
                new Category()
                {
                    CategoryId=4,
                    CategoryName="Cake Recipe",
                    CategoryPoster="CakePoster.jpg",
                    ImageUrl="ImageRecipe.jpg"
                },
                new Category()
                {
                    CategoryId=5,
                    CategoryName="Smoothies",
                    CategoryPoster="SmoothiPoster.jpg",
                    ImageUrl="SmoothiRecipe.jpg"
                },
                new Category()
                {
                    CategoryId=6,
                    CategoryName="Sweets",
                    CategoryPoster="SweetPoster.jpg",
                    ImageUrl="SweetRecipe.jpg"
                }
                  
            };
        }

        public async Task AddCategoryDataToFireBase()
        {
            try
            {
                foreach(var item in categories)
                {
                    await client.Child("Category").PostAsync(new Category()
                    {
                        CategoryId=item.CategoryId,
                        CategoryName=item.CategoryName,
                        CategoryPoster=item.CategoryPoster,
                        ImageUrl=item.ImageUrl,
                    });
                        
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error",ex.Message,"Ok");
            }

        }
    }
}
