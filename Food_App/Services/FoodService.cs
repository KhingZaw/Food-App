﻿using Food_App.Model;
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
    public Task<List<Food>> GetCategoryAsync()
    {
        List<Food> items = new List<Food>()
        {

            new Food(){ foodID = 1 , image ="burger.png",title = "Beef Burger",price = 40,description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...",total = 3, rating = 4.5 ,favorites = true,selecte = false,ingredients =1},
            new Food(){ foodID = 2 , image ="promotions.png",title = "Goat Meat Burger",price = 50,description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...",total = 3, rating = 4.5 ,favorites = true,selecte = false,ingredients = 2},
            new Food(){ foodID = 3 , image ="foodlog1.png",title = "Vegetables Piza",price = 20,total = 3,description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", rating = 4.5 ,favorites = true,selecte = false,ingredients = 3},
            new Food(){ foodID = 4 , image = "pizza.png", title = "Chicken Pizza", price = 30, total = 4,description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", rating = 4.5 ,favorites = true,selecte = false,ingredients = 4},
            new Food(){ foodID = 5 , image = "dessert.png", title = "Dessert", price = 10,description="Be inspired by our juicy, flavour-packed beef burger recipes– stack them up on buns with cheese, bacon, lettuce and more...", total = 5, rating = 4.5 ,favorites = true,selecte = false,ingredients = 5},

        };
        
        return Task.FromResult(items);
    }
    
    public Task<List<Ingredient>> GetIngredient()
    {
         List<Ingredient> ingredient = new List<Ingredient>()
        {

            new Ingredient { ingredientID = 1 ,ingredients = 1, images ="burger.png" , name = "Beef Burger" , selecete=true},
            new Ingredient { ingredientID = 2 ,ingredients = 1, images ="foodlog1.png" , name = "Vegetables Burger" , selecete=false},
            new Ingredient { ingredientID = 3 ,ingredients = 1, images ="dessert.png" , name = "Dessert" , selecete=true},

            new Ingredient { ingredientID = 4 ,ingredients = 2, images ="pizza.png" , name = "Chicken Burger" , selecete=true},
            new Ingredient { ingredientID = 5 ,ingredients = 2, images ="promotions.png" , name = "Goat Meat Burger" , selecete=false},
            new Ingredient { ingredientID = 6 ,ingredients = 2, images ="burger.png" , name = "Beef Burger" , selecete=true},

            new Ingredient { ingredientID = 7 ,ingredients = 3, images ="foodlog1.png" , name = "Vegetables Burger" , selecete=true},
            new Ingredient { ingredientID = 8 ,ingredients = 3, images ="dessert.png" , name = "Dessert" , selecete=false},
            new Ingredient { ingredientID = 9 ,ingredients = 3, images ="pizza.png" , name = "Chicken Burger" , selecete=true},

            new Ingredient { ingredientID = 10 ,ingredients = 4, images ="promotions.png" , name = "Goat Meat Burger" , selecete=true},
            new Ingredient { ingredientID = 11 ,ingredients = 4, images ="burger.png" , name = "Beef Burger" , selecete=false},
            new Ingredient { ingredientID = 12 ,ingredients = 4, images ="foodlog1.png" , name = "Vegetables Burger" , selecete=true},

            new Ingredient { ingredientID = 13 ,ingredients = 5, images ="dessert.png" , name = "Dessert" , selecete=true},
            new Ingredient { ingredientID = 14 ,ingredients = 5, images ="pizza.png" , name = "Chicken Burger" , selecete=false},
            new Ingredient { ingredientID = 15 ,ingredients = 5, images ="promotions.png" , name = "Goat Meat Burger" , selecete=true},
        };

        //var ingrediented = ingredient.Where(x => x.ingredientID.ToString() == food.ingredientID.ToString());

        return Task.FromResult(ingredient);
    }

}