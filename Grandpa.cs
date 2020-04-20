using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Grandpa : Customer
    {
        // Member variables

        // constructor
        public Grandpa()
        {

        }

        // Member methods
        public override void SetName(string name)
        {
            this.name = name + " " + maleNames[namePicker.Next(0, maleNames.Count)];
        }

        public override bool BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= .40 &&
                weather.condition != "Rain" && 
                weather.temperature > 60 &&
                recipe.amountOfLemons >= recipe.amountOfSugarCubes)     // sour
            {
                if ((weather.temperature > 85 && recipe.amountOfIceCubes >= 3) ||     // more ice when it's hot
                    recipe.amountOfIceCubes <= 1)                                     // otherwise, little ice
                {
                    return true;
                }
            }

            return false;
        }
    }
}
