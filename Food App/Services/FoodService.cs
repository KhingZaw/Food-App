using Food_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_App.Services;

public class FoodService
{
    HttpClient httpClient;

    public FoodService()
    {
        this.httpClient = new HttpClient();
    }
    public Task<List<Food>> GetFoodAsync()
    {
        List<Food> items = new List<Food>()
        {

            new Food(){ FoodID = 1 , Image ="burger.png",Title = "Beef Burger",Price = 40,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5 ,Selecte = false,Ingredients =1,ProductIsFav = true},
            new Food(){ FoodID = 2 , Image ="promotions.png",Title = "Goat Meat Burger",Price = 50,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...",Rating = 4.5,Selecte = false,Ingredients = 2,ProductIsFav=false},
            new Food(){ FoodID = 3 , Image ="foodlog1.png",Title = "Vegetables Piza",Price = 20,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5 ,Selecte = false,Ingredients = 3,ProductIsFav=false},
            new Food(){ FoodID = 4 , Image = "pizza.png", Title = "Chicken Pizza", Price = 30,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5 ,Selecte = false,Ingredients = 4,ProductIsFav = true},
            new Food(){ FoodID = 5 , Image ="burger.png",Title = "Beef Burger",Price = 40,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5 ,Selecte = false,Ingredients =1,ProductIsFav=true},
            new Food(){ FoodID = 6 , Image ="promotions.png",Title = "Goat Meat Burger",Price = 50,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...",Rating = 4.5,Selecte = false,Ingredients = 2,ProductIsFav=false},
            new Food(){ FoodID = 7 , Image ="foodlog1.png",Title = "Vegetables Piza",Price = 20,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5 ,Selecte = false,Ingredients = 3,ProductIsFav=false},
            new Food(){ FoodID = 8 , Image = "pizza.png", Title = "Chicken Pizza", Price = 30,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5 ,Selecte = false,Ingredients = 4,ProductIsFav = true},
            new Food(){ FoodID = 9 , Image = "dessert.png", Title = "Dessert", Price = 10,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5,Selecte = false,Ingredients = 5, ProductIsFav = true},
            new Food(){ FoodID = 10 , Image ="foodlog1.png",Title = "Vegetables Piza",Price = 20,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5 ,Selecte = false,Ingredients = 3,ProductIsFav=false},
            new Food(){ FoodID = 11 , Image = "pizza.png", Title = "Chicken Pizza", Price = 30,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5 ,Selecte = false,Ingredients = 4,ProductIsFav = true},
            new Food(){ FoodID = 12, Image = "dessert.png", Title = "Dessert", Price = 10,Description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", Rating = 4.5,Selecte = false,Ingredients = 5, ProductIsFav = true},

        };

        return Task.FromResult(items);
    }

    public Task<List<Ingredient>> GetIngredient()
    {
        List<Ingredient> ingredient = new List<Ingredient>()
        {

            new Ingredient { IngredientID = 1 , Images ="burger.png" , Name = "Beef Burger" , Selecete=true},
            new Ingredient { IngredientID = 2 , Images ="foodlog1.png" , Name = "Vegetables Burger" , Selecete=false},
            new Ingredient { IngredientID = 3, Images ="dessert.png" , Name = "Dessert" , Selecete=true},

            new Ingredient { IngredientID = 4, Images ="pizza.png" , Name = "Chicken Burger" , Selecete=true},
            new Ingredient { IngredientID = 5, Images ="promotions.png" , Name = "Goat Meat Burger" , Selecete=false},
            new Ingredient { IngredientID = 6, Images ="burger.png" , Name = "Beef Burger" , Selecete=true},

            new Ingredient { IngredientID = 7, Images ="foodlog1.png" , Name = "Vegetables Burger" , Selecete=true},
            new Ingredient { IngredientID = 8, Images ="dessert.png" , Name = "Dessert" , Selecete=false},
            new Ingredient { IngredientID = 9, Images ="pizza.png" , Name = "Chicken Burger" , Selecete=true},

            new Ingredient { IngredientID = 10, Images ="promotions.png" , Name = "Goat Meat Burger" , Selecete=true},
            new Ingredient { IngredientID = 11, Images ="burger.png" , Name = "Beef Burger" , Selecete=false},
            new Ingredient { IngredientID = 12, Images ="foodlog1.png" , Name = "Vegetables Burger" , Selecete=true},

            new Ingredient { IngredientID = 13, Images ="dessert.png" , Name = "Dessert" , Selecete=true},
            new Ingredient { IngredientID = 14, Images ="pizza.png" , Name = "Chicken Burger" , Selecete=false},
            new Ingredient { IngredientID = 15, Images ="promotions.png" , Name = "Goat Meat Burger" , Selecete=true},
        };

        return Task.FromResult(ingredient);
    }

}
