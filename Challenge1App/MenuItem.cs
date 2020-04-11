using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1App
{
    public class MenuItem
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }

        public List<string> Ingredients { get; set; }

        public double MealCost { get; set; }

        public MenuItem() { }

        public MenuItem(
            int mealNumber,
            string mealName,
            string mealDescription,
            List<string> ingredients,
            double mealCost)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredients = ingredients;
            MealCost = mealCost;
        }

        public void AddIngredientsToItem(string ingredientToAdd)
        {
            Ingredients.Add(ingredientToAdd);
        }

        
    }
}
