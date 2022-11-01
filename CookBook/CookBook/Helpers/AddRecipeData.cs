using CookBook.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CookBook.Helpers
{
    public class AddRecipeData
    {

        public List<RecipeList> RecipeListsOC { get; set; }
        FirebaseClient client;
        public AddRecipeData()
        {
            client = new FirebaseClient("https://cookbook-528e5-default-rtdb.firebaseio.com/");
            RecipeListsOC = new List<RecipeList>()
            {
                new RecipeList()
                {
                    CategoryId=1,
                    RecipeId=1,
                    RecipeName="creamy white pasta ",
                    Calories=696,
                    RecipeKind="Veg",
                    CookTime=30,
                    PrepTime=10,
                    NumberOfServing=2,
                    IngredientsRequired=new List<string>()
                    {
                        "2 tbsp oil", "3 clove garlic (finely chopped)", "1/2 onion (chopped)", "1/2 carrot (chopped)", "½ capsicum (chopped)", "3 tbsp sweet corn", "½ tsp pepper (crushed)", "2 tbsp butter", "3 tbsp maida / plain flour", "2 cup milk", "½ tsp chilli flakes", "½ tsp mixed herbs", "½ tsp salt", "cheese (for garnishing)" ,
                    },
                    Directions= new List<string>()
                    {
                         "firstly, in a large kadai boil 6 cup water and 1 tsp salt.",
                    "once the water comes to a boil, add 2 cup pasta. i have used elicoidali pasta, you can alternatively use penne pasta.",
                    "boil for 7 minutes, or until the pasta is cooked al dente.",
                    "drain off the pasta and keep aside.",
                    "in a frying pan, heat 2 tbsp oil and saute 3 clove garlic.",
                    "add ½ onion, ½ carrot, ½ capsicum and 3 tbsp sweet corn.",
                    "saute for a minute or until vegetables shrink slightly yet remain crunchy.",
                    "further, add ½ tsp pepper and ½ tsp salt.",
                    "saute well until the spices are well combined. keep aside.",
                    "to prepare white sauce for pasta, heat 2 tbsp butter.",
                    "add 3 tbsp maida and saute on low flame.",
                    "saute until the maida turns aromatic yet do not change its colour.",
                    "now add 1 cup milk and mix well.",
                    "mix until the sauce thickens without forming any lumps.",
                    "further, add 1 more cup of milk and continue to stir continuously.",
                    "mix continuously, until the sauce thickens. if required using a whisk break the lumps.",
                    "cook until the sauce turns silk smooth and creamy texture.",
                    "now add ½ tsp pepper, ½ tsp chilli flakes, ½ tsp mixed herbs and ½ tsp salt.",
                    "mix well making sure everything is well combined.",
                    "add in sauted vegetables and combine well.",
                    "now add in boiled pasta and mix gently.",
                    "add 2 tbsp of boiled pasta water if the sauce thickens.",
                    "mix gently making sure everything is well combined.",
                    "finally, just before serving white sauce pasta, garnish with grated cheese."
                    },
                    ImageUrl="pasta1.jpg",
                    likes=250,
                    Rating=4.5,
                },
                new RecipeList()
                {
                    CategoryId=1,
                    RecipeId=2,
                    RecipeName="Pasta Bake with Sausage",
                    Calories=595,
                    CookTime=50,
                    PrepTime=10,
                    likes=40,
                    Rating=4.2,
                    NumberOfServing=2,
                    RecipeKind="Nog Veg",
                    IngredientsRequired= new List<string>()
                    {
                        "pasta","olive oil","Italian sausage","onion","garlic","tomato sauce","herbs","cheese","salt and pepper"
                    },
                    Directions = new List<string>()
                    {
                        "Boil the pasta. Bring a large pot of salted water to a boil over medium-high heat. Add pasta and cook until al dente (fully cooked but still firm), about 8-10 minutes, or according to package directions. Drain well and set aside.",
                        "Cook the sausage. Meanwhile, heat olive oil in a large pot (or 4 qt. Dutch oven) for 2 minutes over medium-high heat until the hot oil sizzles. Add sausage and stir to cook until browned, about 5-7 minutes. Use a spatula to break the sausages into small pieces. Add onions and garlic and sauté until soft and tender, about 2-3 minutes. Stir to combine.",
                        "Make the sauce. Pour in tomato sauce, turn the heat down to medium, and bring the meat sauce to a simmer, stirring occasionally. Stir in Italian seasoning, ½ cup Parmesan cheese, parsley and basil. Season with salt and pepper. Turn the heat down to low and simmer for 5-7 minutes, stirring occasionally. Simmering helps develop richer flavour in the sauce.",
                        "Add the pasta. Transfer the cooked and drained pasta into the sauce and toss well to mix evenly.",
                        "Assemble. Spread half of the pasta into a 9x13 casserole pan and top with half of mozzarella cheese (1.5 cups). Add the remaining pasta and sprinkle the remaining mozzarella and Parmesan cheese evenly on top.",
                        "Bake. Bake the pasta in a 375F preheated oven for 25 minutes until the melted cheese is golden brown. Let cool for 15 minutes, then serve."
                    },
                    ImageUrl="pasta2.png"                   
                },
                new RecipeList(){
                    CategoryId=1,
                    RecipeId=3,
                    CookTime=10,
                    PrepTime=10,
                    NumberOfServing=2,
                    Rating=5,
                    RecipeKind="Veg",
                    Calories=683,
                    likes=245,
                    RecipeName="indian style pasta recipe",
                    IngredientsRequired= new List<string>(){
                        "2 cup pasta","2 tbsp olive oil","1 tbsp butter","2 clove garlic (finely chopped)","1 chilli (slit)","1 inch ginger (chopped)","½ onion (finely chopped)","1 tsp chilli powder","½ tsp turmeric","2 cup tomato puree","½ tsp coriander powder","½ tsp cumin powder","½ tsp garam masala","½ tsp salt","2 tbsp sweet corn","2 tbsp carrot (chopped)","2 tbsp capsicum (chopped)","½ cup pasta boiled water","2 tbsp tomato sauce","1 tsp mixed herbs","1 tsp chilli flakes","½ cup cheese (grated)","2 tbsp coriander (finely chopped)"
                    },
                    Directions=new List<string>()
                    {
                        "firstly, in a large vessel take 2 litre water and 1 tbsp salt.",
                        "get the water to a rolling boil. once the water comes to a boil, add 2 cup pasta.",
                        "boil for 7 minutes or until the pasta is al dente. make sure to check the cooking time on package instructions.",
                        "drain off the pasta and rinse with cold water to stop from cooking further. keep aside.",
                        "to prepare pasta sauce, in a large wok heat 2 tbsp olive oil and 1 tbsp butter.",
                        "add 2 clove garlic, 1 chilli and 1 inch ginger. saute slightly.",
                        "also, saute ½ onion until the onions shrink slightly.",
                        "keeping the flame on low, add 1 tsp chilli powder and ½ tsp turmeric.",
                        "saute on low flame until the spices turn aromatic.",
                        "further, add 2 cup tomato puree and cook well.",
                        "cook until the mixture thickens and oil separates.",
                        "also add ½ tsp coriander powder, ½ tsp cumin powder, ½ tsp garam masala and ½ tsp salt.",
                        "saute on low flame until the spices turn aromatic.",
                        "add 2 tbsp sweet corn, 2 tbsp carrot and 2 tbsp capsicum. cook for a minute.",
                        "now add ½ cup pasta boiled water, 2 tbsp tomato sauce, 1 tsp mixed herbs and 1 tsp chilli flakes.",
                        "cook until the spices are well combined.",
                        "further, add ½ cup cheese and mix well. cheesy pasta sauce is ready.",
                        "now add boiled pasta and mix well making sure the pasta sauce is well combined with pasta.",
                        "finally, enjoy desi masala pasta topped with cheese and coriander."
                    },
                    ImageUrl="pasta3.png",
                }
            };
        }
        public async Task AddRecipeToFirebase()
        {
            try
            {
                foreach(var item in RecipeListsOC)
                {
                    await client.Child("RecipeList").PostAsync(new RecipeList()
                    {
                        CategoryId = item.CategoryId,
                        RecipeId = item.RecipeId,
                        RecipeName = item.RecipeName,
                        Calories = item.Calories,
                        CookTime = (int)item.CookTime,
                        NumberOfServing = (int)item.NumberOfServing,
                        Directions = item.Directions,
                        ImageUrl = item.ImageUrl,
                        IngredientsRequired = item.IngredientsRequired,
                        likes = item.likes,
                        Rating = item.Rating,
                        PrepTime = (int)item.PrepTime,
                        RecipeKind = item.RecipeKind,
                    });
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}
