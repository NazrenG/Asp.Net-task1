using System.Collections.Generic;

namespace WebApplication1.Entities
{
    public class HotMeal
    { 
        public string Name { get; set; }
        public string FoodType { get; set; }
        public List<string> Ingredients { get; set; }
        public double Price { get; set; }
        public bool IsVegetarian { get; set; }
    }
}
