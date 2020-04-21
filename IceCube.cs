using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class IceCube : Item
    {
        // member variables

        // constructor
        public IceCube()
        {
            name = "ice cube";
            daysInInventory = 0;
        }

        // member methods
        public override bool Spoiled()
        {
            daysInInventory++;
            if (daysInInventory >= Constants.daysToSpoilIceCube)
                return true;

            return false;
        }
    }
}
