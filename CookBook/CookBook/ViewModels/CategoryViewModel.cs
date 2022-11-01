using CookBook.Models;
using CookBook.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CookBook.ViewModels
{
    public class CategoryViewModel
    {
        public ObservableCollection<Category> categoriesList { get; set; }
        public CategoryViewModel()
        {
            categoriesList = new ObservableCollection<Category>();
            getCategoriesFromService();
        }

        private async void getCategoriesFromService()
        {
            var Service = new CategoryDataService();
            var item = await Service.GetCategories();
            foreach(var items in item)
            {
                categoriesList.Add(items);
            }
        }
    }
}
