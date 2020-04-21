using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Cup : Item
    {
        // member variables

        // constructor
        public Cup()
        {
            name = "cup";
            daysInInventory = 0;
        }

        // member methods
        public override bool Spoiled()
        {
            daysInInventory++;
            if (daysInInventory >= Constants.daysToSpoilCup)
                return true;

            return false;
        }
    }
}
