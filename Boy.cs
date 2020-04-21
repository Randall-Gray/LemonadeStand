using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Boy : Customer
    {
        // Member variables

        // constructor

        // Member methods
        public override void SetName(string name)
        {
            this.name = maleNames[namePicker.Next(0, maleNames.Count)] + " the " + name;
        }

        public override bool BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= Constants.boyMaxPrice &&
                recipe.amountOfLemons >= recipe.amountOfSugarCubes &&      // sour
                recipe.amountOfIceCubes >= Constants.boyMinIce)
            {
                return true;
            }
        
            return false;
        }
    }
}
