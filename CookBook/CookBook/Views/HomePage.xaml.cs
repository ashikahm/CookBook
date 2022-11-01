using CookBook.Models;
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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Users selection = e.CurrentSelection.FirstOrDefault() as Users;
            if(selection == null)
            {
                return;
            }
            await Navigation.PushAsync(new VedioPlayingView(selection));
            ((CollectionView)sender).SelectedItem = null;
        }

        private async void CollectionView_SelectionChanged_LatestRecipe(object sender, SelectionChangedEventArgs e)
        {
            RecipeList selection = e.CurrentSelection.FirstOrDefault() as RecipeList;
            if (selection == null)
            {
                return;
            }
            await Navigation.PushAsync(new RecipeView(selection));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}