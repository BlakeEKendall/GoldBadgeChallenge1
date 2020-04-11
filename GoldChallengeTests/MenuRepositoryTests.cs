using Challenge1App;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldChallengeTests
{
    [TestClass]
    public class MenuRepositoryTests
    {
        MenuItemRepository repo = new MenuItemRepository();

        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void AddItemToMenu_ShouldGetCorrectBoolean()
        {
            MenuItem burger = new MenuItem();
            burger.MealName = "Hamburger";

            bool wasAdded = repo.AddMenuItemToMenu(burger);
            Assert.IsTrue(wasAdded);

            Assert.AreEqual("Hamburger", burger.MealName);
        }

        [TestMethod]
        public void DeleteItemFromMenu_ShouldGetCorrectCount()
        {
            MenuItem milkshake = new MenuItem();
            milkshake.MealName = "Milkshake";
            milkshake.MealNumber = 12;

            repo.AddMenuItemToMenu(milkshake);
            int count = repo.GetWholeMenu().Count;

            repo.DeleteMenuItemFromMenu(milkshake);
            int reCount = repo.GetWholeMenu().Count;

            Assert.AreNotEqual(count, reCount);

        }

        [TestMethod]
        public void DeleteItemByName_ShouldGetCorrectBool()
        {
            MenuItem onionRings = new MenuItem();
            onionRings.MealName = "Onion Rings";

            repo.AddMenuItemToMenu(onionRings);

            bool wasRemoved = repo.RemoveItemsByName("Onion Rings");

            Assert.AreEqual(wasRemoved, true);




        }
    }
}
