using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Grandma : Customer
    {
        // Member variables

        // constructor
        public Grandma()
        {

        }

        // Member methods
        public override void SetName(string name)
        {
            this.name = femaleNames[namePicker.Next(0, maleNames.Count)] + " the " + name;
        }

        public override int BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= Constants.grandmaMaxPrice &&
                weather.Condition != "Rain" &&
                weather.Temperature > Constants.grandmaMinTemp &&
                recipe.amountOfSugarCubes >= recipe.amountOfLemons)     // sweet
            {
                if ((weather.Temperature > Constants.grandmaMoreIceTemp && recipe.amountOfIceCubes >= Constants.grandmaMinIceHot) ||     // more ice when it's hot
                    recipe.amountOfIceCubes <= Constants.grandmaMinIce)                                     // otherwise, little ice
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
