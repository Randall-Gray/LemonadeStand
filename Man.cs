using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Man : Customer
    {
        // Member variables

        // constructor
        public Man()
        {

        }

        // Member methods
        public override void SetName(string name)
        {
            this.name = name + " " + maleNames[namePicker.Next(0, maleNames.Count)];
        }

        public override bool BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= 1.00 &&
                weather.temperature > 50 &&
                recipe.amountOfSugarCubes == recipe.amountOfLemons)     // not too sweet or sour
            {
                if ((weather.temperature > 70 && recipe.amountOfIceCubes >= 3) ||     // more ice when it's hot
                    recipe.amountOfIceCubes >= 2)                                     
                {
                    return true;
                }
            }

            return false;
        }

    }
}
