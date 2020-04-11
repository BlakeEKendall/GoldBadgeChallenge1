using System;
using Challenge1App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoldChallengeTests
{
    [TestClass]
    public class MenuItemTests
    {
        [TestMethod]
        public void MenuItemCreationTests()
        {
            MenuItem waffles = new MenuItem();
            waffles.MealNumber = 7;
            waffles.MealName = "Belgian Waffles";
            waffles.MealCost = 8.99;

            MenuItem omlette = new MenuItem();
            omlette.MealName = "Western Omlette";
            omlette.MealDescription = "An omlette with spicy peppers, queso, hot sauce, and chorizo";

            Console.WriteLine($"New on the menu: {omlette.MealName}: {omlette.MealDescription}.");

            Console.WriteLine($"Item number {waffles.MealNumber} is {waffles.MealName} and it costs ${waffles.MealCost}.");
        }
        
        [TestMethod]
        public void SetName_ShouldSetCorrectString()
        {
            MenuItem burger = new MenuItem();

            burger.MealName = "Cheeseburger with Fries";

            string expected = "Cheeseburger with Fries";
            string actual = burger.MealName;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetPrice_ShouldGetCorrectPrice()
        {
            MenuItem milkshake = new MenuItem();
            milkshake.MealCost = 2.99;

            double expected = 2.99;
            double actual = milkshake.MealCost;

            Assert.AreEqual(expected, actual);
        }

    }


}
