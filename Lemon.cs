using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Lemon : Item
    {
        // member variables

        // constructor
        public Lemon()
        {
            name = "lemon";
            daysInInventory = 0;
        }

        // member methods
        public override bool Spoiled()
        {
            daysInInventory++;
            if (daysInInventory >= Constants.daysToSpoilLemon)
                return true;

            return false;
        }
    }
}
