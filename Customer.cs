﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    abstract class Customer
    {
        // member variables
        private List<string> names;
        public string name;

        // constructor
        public Customer()
        {
            names = new List<string>();
        }

        // member methods
    }
}
