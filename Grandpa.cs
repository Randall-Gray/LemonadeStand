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
            this.name = maleNames[namePicker.Next(0, maleNames.Count)] + " the " + name;
        }

        public override int BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= Constants.grandpaMaxPrice &&
                weather.Condition != "Rain" && 
                weather.Temperature > Constants.grandpaMinTemp &&
                recipe.amountOfLemons >= recipe.amountOfSugarCubes)     // sour
            {
                if ((weather.Temperature > Constants.grandpaMoreIceTemp && recipe.amountOfIceCubes >= Constants.grandpaMinIceHot) ||     // more ice when it's hot
                    recipe.amountOfIceCubes <= Constants.grandpaMinIce)                                     // otherwise, little ice
                {
                    return 1;
                }
            }

            return 0;
        }
    }
}
