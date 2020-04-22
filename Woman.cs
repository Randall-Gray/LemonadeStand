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
            this.name = femaleNames[namePicker.Next(0, femaleNames.Count)] + " the " + name;
        }

        public override int BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= Constants.womanMaxPrice &&
                weather.Condition != "Rain" &&
                weather.Temperature >= Constants.womanMinTemp &&
                recipe.amountOfSugarCubes >= recipe.amountOfLemons)     // sweet
            {
                if ((weather.Temperature > Constants.womanMoreIceTemp && recipe.amountOfIceCubes >= Constants.womanMinIceHot) ||     // more ice when it's hot
                    recipe.amountOfIceCubes >= Constants.womanMinIce)
                {
                    if (weather.Temperature > Constants.womanTwoCupTemp)
                        return 2;
                    else
                        return 1;
                }
            }

            return 0;
        }
    }
}
