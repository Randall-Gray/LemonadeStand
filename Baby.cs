using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Baby : Customer
    {
        // Member variables

        // constructor

        // Member methods
        public override void SetName(string name)
        {
            if (namePicker.Next(0, 1) == 1)   // it's a boy!!
                this.name = maleNames[namePicker.Next(0, maleNames.Count)] + " the " + name;
            else    // it's a girl!!
                this.name = femaleNames[namePicker.Next(0, maleNames.Count)] + " the " + name;
        }

        public override bool BuysLemonade(Weather weather, Recipe recipe)
        {
            return false;       // Baby's don't drink lemonade!!
        }
    }
}
