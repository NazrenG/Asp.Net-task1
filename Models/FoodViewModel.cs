using System.Collections.Generic;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class FoodViewModel
    {
        public List<HotMeal> Meals { get; set; }
        public List<Drink> Drinks { get; set; }
        public List<FastFood> Foods { get; set; }
    }
}