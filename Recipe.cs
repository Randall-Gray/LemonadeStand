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
        public void UpdateRecipe(int numLemons, int numSugarCubes, int numIceCubes)
        {
            amountOfLemons = numLemons;
            amountOfSugarCubes = numSugarCubes;
            amountOfIceCubes = numIceCubes;
        }
    }
}
