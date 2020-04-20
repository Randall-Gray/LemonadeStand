using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Girl : Customer
    {
        // Member variables

        // constructor

        // Member methods
        public override void SetName(string name)
        {
            this.name = name + " " + femaleNames[namePicker.Next(0, femaleNames.Count)];
        }

        public override bool BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= .25 &&
                weather.condition != "Rain" &&
                recipe.amountOfSugarCubes >= recipe.amountOfLemons &&      // sweet
                recipe.amountOfIceCubes >= 2)
            {
                return true;
            }

            return false;
        }

    }
}
