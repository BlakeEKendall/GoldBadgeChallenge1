using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1App
{
    public class ProgramUI
    {
        private readonly MenuItemRepository _repo = new MenuItemRepository();
        
        //private List<string> newIngredients;

        public void Run()
        {
            SeedMenu();
            RunMenu();
        }

        private void SeedMenu()
        {
            MenuItem pancakes = new MenuItem(
                1,
                "Pancakes",
                "Stack of three pancakes with 2 eggs and sausage",
                new List<string> { "flour", "milk", "sugar", "eggs", "baking powder", "sausage" },
                7.99);
            MenuItem biscuitsAndGravy = new MenuItem(
                2,
                "Biscuits and Gravy",
                "Two biscuits served open-faced topped with sausage gravy",
                new List<string> { "flour", "eggs", "milk", "salt", "pepper", "sausage", "butter", "baking powder" },
                6.99);
            MenuItem cheeseburger = new MenuItem(
                3,
                "Cheeseburger and Fries",
                "A cheeseburger with pickles, and fries on the side",
                new List<string> { "beef", "cheese", "salt", "pepper", "buns", "potatoes", },
                7.50);

            _repo.AddMenuItemToMenu(pancakes);
            _repo.AddMenuItemToMenu(biscuitsAndGravy);
            _repo.AddMenuItemToMenu(cheeseburger);
        }

        private void RunMenu()
        {
            bool programIsRunning = true;
            while (programIsRunning)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the virtual menu for Komodo Cafe!\n" +
                    "Please enter the number of the option you'd like to select:\n" +
                    "1. Add a new Menu Item to the menu\n" +
                    "2. Delete a Menu Item from the menu\n" +
                    "3. Show all Menu Items on the Menu\n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddNewMenuItem();
                        break;
                    case "2":
                        DeleteMenuItem();
                        break;
                    case "3":
                        ShowWholeMenu();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        programIsRunning = false;
                        break;
                    default:
                        break;
                }

            }
        }

        private void AddNewMenuItem()
        {
            Console.Clear();
            Console.WriteLine("Add new menu item number:");
            int itemNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nName this menu item:");
            string itemName = Console.ReadLine();
            Console.WriteLine("\nDescribe this item:");
            string itemDescription = Console.ReadLine();
            Console.WriteLine("\nEnter the ingredients for this item separated by commas:");
            string[] array = Console.ReadLine().Split(',');
            List<string> ingredientsList = new List<string>();
            ingredientsList.AddRange(array);
            
            Console.WriteLine("\nEnter the cost of the menu item:");
            double itemCost = Convert.ToDouble(Console.ReadLine());

            MenuItem newMenuItem = new MenuItem(itemNumber, itemName, itemDescription, ingredientsList, itemCost);

            bool itemWasAdded = _repo.AddMenuItemToMenu(newMenuItem);
            if (itemWasAdded)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Error, please try again.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }

        private void DeleteMenuItem()
        {
            Console.Clear();
            List<MenuItem> currentMenuItems = _repo.GetWholeMenu();
            foreach (MenuItem item in currentMenuItems)
            {
                Console.WriteLine($"Meal number:{item.MealNumber}, {item.MealName} \n");
            }
            Console.WriteLine("\nType the name of the item you want to delete:");
            string mealToDelete = Console.ReadLine();
            bool itemWasRemoved = _repo.RemoveItemsByName(mealToDelete);
            if (itemWasRemoved)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Error, please try again.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }

        private void ShowWholeMenu()
        {
            Console.Clear();

            int index = 1;
            List<MenuItem> items = _repo.GetWholeMenu();
            foreach (MenuItem item in items)
            {
                    Console.WriteLine($"{index++}. Meal number {item.MealNumber} is {item.MealName}: \n" +
                    $"{item.MealDescription}, \n" +
                    $"and it costs ${item.MealCost}.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        

        //private void TakeInIngredientsList()
        //{
        //    List<string> _ingredients = new List<string>();


        //    char addAnotherIngredient = 'N';


        //    do
        //    {
        //        Console.WriteLine("Enter ingredient name:");
        //        string userInput = Console.ReadLine();
        //        _ingredients.Add(userInput);
        //        Console.WriteLine("Do you want to add another ingredient [Y/N]? : ");
        //        addAnotherIngredient = char.ToUpper(Console.ReadKey(false).KeyChar);


        //    } while (addAnotherIngredient == 'Y');
        //}

        //private void CreateIngredientList()
        //{
        //    //List<Ingredient> ingredients = new List<Ingredient>();

        //    //char addAnotherIngredient = 'N';

        //    //do
        //    //{
        //    //    var ingreds = new Ingredient();

        //    //    Console.Write(" Enter Ingredient name: ");
        //    //    ingreds.Name = Console.ReadLine();
        //    //    ingredients.Add(ingreds); //Add the ingredient to the List<Ingredient> defined above

        //    //    //Confirm if another ingredient to be added
        //    //    Console.Write("Do you want to add another Ingredient [Y/N]? : ");
        //    //    addAnotherIngredient = char.ToUpper(Console.ReadKey(false).KeyChar); //Compare always upper case input irrespective of user input casing.

        //    //} while (addAnotherIngredient == 'Y');
        //}
    }
}
