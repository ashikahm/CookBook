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
    public partial class RecipeView : ContentPage
    {
        RecipeViewModel viewModel;
        public RecipeView(RecipeList selectedRecipe)
        {
            viewModel = new RecipeViewModel(selectedRecipe);
            this.BindingContext= viewModel;
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}