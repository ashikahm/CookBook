using CookBook.ViewModel;
using CookBook.Helpers;
using CookBook.Models;
using CookBook.Services;
using CookBook.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using Xamarin.Forms;

namespace CookBook.ViewModels
{
    public class HomeViewModel:BaseViewModel
    { 
        
        public ObservableCollection<Users> GetUsersInfo { get; set; } 
        public ObservableCollection<RecipeList> LatestRecipe { get; set; }
        public HomeViewModel()
        {
            GetUsersInfo = new ObservableCollection<Users>();
            LatestRecipe = new ObservableCollection<RecipeList>();             
            GetLatestRecipe();
            GetUsersInfoMethod();
        }


        private async void GetLatestRecipe()
        {
            var RDS = new RecipeDataService();
            var items = await RDS.GetLatestRecipeAsync();
            foreach(var item in items)
            {
                LatestRecipe.Add(item);
            }
        }

        private void GetUsersInfoMethod()
        {
            var aud = new AddUserData();
            var items = aud.getusers();
            foreach(var item in items)
            {
                GetUsersInfo.Add(item);
            }
        }
    }
}
