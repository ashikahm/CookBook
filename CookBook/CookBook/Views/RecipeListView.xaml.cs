using CookBook.Models;
using CookBook.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeListView : ContentPage
    {
        RecipeListViewModel recipeListViewModel;
        public RecipeListView(Category selected)
        {
            recipeListViewModel = new RecipeListViewModel(selected);
            this.BindingContext = recipeListViewModel;
            InitializeComponent();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = e.CurrentSelection.FirstOrDefault() as RecipeList;
            if(selected==null)
                return;
            await Navigation.PushAsync(new RecipeView(selected));
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}