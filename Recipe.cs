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
        // amount of ingredients per cup
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
            amountOfLemons = UserInterface.GetNumberOfItemsForRecipe("lemons", amountOfLemons);
            amountOfSugarCubes = UserInterface.GetNumberOfItemsForRecipe("sugar cubes", amountOfSugarCubes);
            amountOfIceCubes = UserInterface.GetNumberOfItemsForRecipe("ice cubes", amountOfIceCubes);
            pricePerCup = UserInterface.GetPricePerCup(pricePerCup);
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
