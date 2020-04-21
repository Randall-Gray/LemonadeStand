using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class SugarCube : Item
    {
        // member variables

        // constructor
        public SugarCube()
        {
            name = "sugar cube";
            daysInInventory = 0;
        }

        // member methods
        public override bool Spoiled()
        {
            daysInInventory++;
            if (daysInInventory >= Constants.daysToSpoilSugarCube)
                return true;

            return false;
        }
    }
}
