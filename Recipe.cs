using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        // member variables
        // amount of ingredients per pitcher
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;

        public double pricePerCup;

        // constructor
        public Recipe()
        {
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            amountOfIceCubes = 0;
            pricePerCup = 0;
        }

        // member methods
        public void SetRecipeAndPrice()
        {
            DisplayRecipe();
            amountOfLemons = UserInterface.GetNumberOfItemsForRecipe("lemons");
            amountOfSugarCubes = UserInterface.GetNumberOfItemsForRecipe("sugar cubes");
            amountOfIceCubes = UserInterface.GetNumberOfItemsForRecipe("ice cubes");
            pricePerCup = UserInterface.GetPricePerCup();
            DisplayRecipe();
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("\nLemonade Recipe  (per 12 cup pitcher)");
            Console.WriteLine("Lemons: " + amountOfLemons);
            Console.WriteLine("Sugar Cubes: " + amountOfSugarCubes);
            Console.WriteLine("Ice Cubes: " + amountOfIceCubes);
            Console.WriteLine("\nPrice per cup: {0:C}\n", pricePerCup);
        }
    }
}
