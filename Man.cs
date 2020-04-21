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
            this.name = maleNames[namePicker.Next(0, maleNames.Count)] + " the " + name;
        }

        public override bool BuysLemonade(Weather weather, Recipe recipe)
        {
            if (recipe.pricePerCup <= Constants.manMaxPrice &&
                weather.Temperature >= Constants.manMinTemp &&
                recipe.amountOfSugarCubes == recipe.amountOfLemons)     // not too sweet or sour
            {
                if ((weather.Temperature > Constants.manMoreIceTemp && recipe.amountOfIceCubes >= Constants.manMinIceHot) ||     // more ice when it's hot
                    recipe.amountOfIceCubes >= Constants.manMinIce)                                     
                {
                    return true;
                }
            }

            return false;
        }
    }
}
