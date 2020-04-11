using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1App
{
    public class MenuItemRepository
    {
        public List<MenuItem> _menuItems = new List<MenuItem>();

        public bool AddMenuItemToMenu(MenuItem mealToAdd)
        {
            int startingCount = _menuItems.Count;
            _menuItems.Add(mealToAdd);

            bool wasAdded = (_menuItems.Count > startingCount);
            return wasAdded;
        }

        public bool RemoveItemsByName(string name)
        {
            int startingCount = _menuItems.Count;
            int index = -1;
            foreach (MenuItem item in _menuItems)
            {
                if (item.MealName == name)
                {
                    index = _menuItems.IndexOf(item);
                }
            }
            if (index != -1)
            {
                _menuItems.RemoveAt(index);
            }

            bool wasRemoved = (_menuItems.Count < startingCount);
            return wasRemoved;
        }

        public MenuItem GetMenuItemByName(string name)
        {
            foreach (MenuItem menuItem in _menuItems)
            {
                if (menuItem.MealName == name)
                {
                    return menuItem;
                }
            }

            return null;
        }

        public void DeleteMenuItemFromMenu(MenuItem mealToDelete)
        {
            _menuItems.Remove(mealToDelete);
        }

        public List<MenuItem> GetWholeMenu()
        {
            return _menuItems;
        }
    }
}
