using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            List<HotMeal> meals = new List<HotMeal>  {
            new HotMeal()
            {
                Name = "Grilled Chicken",
                FoodType="Main Course",
                Ingredients=new List<string>{"Chicken Breast", "Olive Oil", "Garlic", "Herbs" },
                IsVegetarian=false,
                Price=23.4,

            },
            new HotMeal()
            {
                Name = "Vegetable Stir Fry",
                FoodType="Main Course",
                Ingredients=new List<string>{"Broccoli", "Bell Peppers", "Carrots", "Soy Sauce", "Ginger" },
                IsVegetarian=true,
                Price=13.2,

            },
            new HotMeal()
            {
                Name = "Beef Stew",
                FoodType="Main Course",
                Ingredients=new List<string>{"Beef", "Potatoes", "Carrots", "Onions", "Celery"},
                IsVegetarian=false,
                Price=14.99,
            }

            };

            List<Drink> drinks = new List<Drink>
            {
                new Drink()
                {
                    Name = "Water",
                    Type="Non-Alcoholic",
                    Price=1.00
                },
                new Drink()
                {
                    Name = "Coffee",
                    Type="Non-Alcoholic",
                    Price=2.50
                },new Drink()
                {
                    Name = "Tea",
                    Type="Non-Alcoholic",
                    Price=2.00
                }
            };

            List<FastFood> foods = new List<FastFood>{
                new FastFood()
                {
                    Name="Cheeseburger",
                    FoodType="Burger",
                    Ingredients=new List<string>{"Beef Patty", "Cheddar Cheese", "Lettuce", "Tomato", "Onion", "Pickles", "Bun"},
                    IsVegetarian=false,
                    Price=5.45,
                    Calories=550,

                },
                new FastFood()
                {
                    Name="Chicken Nuggets",
                    FoodType="Snack",
                    Ingredients=new List<string>{"Chicken", "Breadcrumbs", "Spices"},
                    IsVegetarian=false,
                    Price=4.99,
                    Calories=300,
                }
            };


            var vm = new FoodViewModel
            {
                Meals=meals,
                Drinks=drinks,
                Foods=foods
            };
            return View(vm);
        }

        public IActionResult Drinks()
        {
            List<Drink> drinks = new List<Drink>
            {
                new Drink()
                {
                    Name = "Water",
                    Type="Non-Alcoholic",
                    Price=1.00
                },
                new Drink()
                {
                    Name = "Coffee",
                    Type="Non-Alcoholic",
                    Price=2.50
                },new Drink()
                {
                    Name = "Tea",
                    Type="Non-Alcoholic",
                    Price=2.00
                }
            };
            return View(drinks);
        }

        public IActionResult HotMeals()
        {
            List<HotMeal> meals = new List<HotMeal>  {
            new HotMeal()
            {
                Name = "Grilled Chicken",
                FoodType="Main Course",
                Ingredients=new List<string>{"Chicken Breast", "Olive Oil", "Garlic", "Herbs" },
                IsVegetarian=false,
                Price=23.4,

            },
            new HotMeal()   
            {
                Name = "Vegetable Stir Fry",
                FoodType="Main Course",
                Ingredients=new List<string>{"Broccoli", "Bell Peppers", "Carrots", "Soy Sauce", "Ginger" },
                IsVegetarian=true,
                Price=13.2,

            },
            new HotMeal()
            { 
                Name = "Beef Stew",
                FoodType="Main Course",
                Ingredients=new List<string>{"Beef", "Potatoes", "Carrots", "Onions", "Celery"},
                IsVegetarian=false,
                Price=14.99,
            }

            };
            return View(meals);
        }

        public IActionResult FastFoods()
        {
            List<FastFood> foods = new List<FastFood>{
                new FastFood()
                {
                    Name="Cheeseburger",
                    FoodType="Burger",
                    Ingredients=new List<string>{"Beef Patty", "Cheddar Cheese", "Lettuce", "Tomato", "Onion", "Pickles", "Bun"},
                    IsVegetarian=false,
                    Price=5.45,
                    Calories=550,

                },
                new FastFood()
                {
                    Name="Chicken Nuggets",
                    FoodType="Snack",
                    Ingredients=new List<string>{"Chicken", "Breadcrumbs", "Spices"},
                    IsVegetarian=false,
                    Price=4.99,
                    Calories=300,
                }
            };


            return View(foods);
        }



    }
}
