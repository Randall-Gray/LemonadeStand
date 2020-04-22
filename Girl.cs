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
            this.name = femaleNames[namePicker.Next(0, maleNames.Count)] + " the " + name;
        }

        public override int BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= Constants.girlMaxPrice &&
                weather.Condition != "Rain" &&
                recipe.amountOfSugarCubes >= recipe.amountOfLemons &&      // sweet
                recipe.amountOfIceCubes >= Constants.girlMinIce)
            {
                return 1;
            }

            return 0;
        }
    }
}
