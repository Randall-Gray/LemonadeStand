﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    abstract class Item         
    {
        // member variables
        public string name;
        protected int daysInInventory;

        // constructor
        static Item()
        {

        }

        // member methods
        public abstract bool Spoiled();
    }
}
