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
            this.name = name + " " + maleNames[namePicker.Next(0, maleNames.Count)];
        }

        public override bool BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= .25 &&
                recipe.amountOfLemons >= recipe.amountOfSugarCubes &&      // sour
                recipe.amountOfIceCubes >= 2)
            {
                return true;
            }
        
            return false;
        }

    }
}
