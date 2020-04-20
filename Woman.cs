using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Woman : Customer
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
            if (recipe.pricePerCup <= .90 &&
                weather.condition != "Rain" &&
                weather.temperature > 60 &&
                recipe.amountOfSugarCubes >= recipe.amountOfLemons)     // sweet
            {
                if ((weather.temperature > 80 && recipe.amountOfIceCubes >= 3) ||     // more ice when it's hot
                    recipe.amountOfIceCubes >= 2)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
