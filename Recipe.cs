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
        public void SetRecipeAndPrice(Store store)
        {
            UserInterface.DisplayRecipe(this, GetCostPerCup(store));
            amountOfLemons = UserInterface.GetNumberOfItemsForRecipe("lemons");
            amountOfSugarCubes = UserInterface.GetNumberOfItemsForRecipe("sugar cubes");
            amountOfIceCubes = UserInterface.GetNumberOfItemsForRecipe("ice cubes");
            pricePerCup = UserInterface.GetPricePerCup();
            UserInterface.DisplayRecipe(this, GetCostPerCup(store));
        }

        private double GetCostPerCup(Store store)
        {
            return (amountOfLemons * store.pricePerLemon + 
                    amountOfSugarCubes * store.pricePerSugarCube) / Constants.maxCupsInPitcher
                    + amountOfIceCubes * store.pricePerIceCube + store.pricePerCup;
        }
    }
}
