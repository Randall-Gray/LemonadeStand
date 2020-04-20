using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    abstract class Customer
    {
        // member variables
        public string name;

        static protected List<string> maleNames;
        static protected List<string> femaleNames;
        
        static protected Random namePicker;

        // constructor
        static Customer()
        {
            maleNames = new List<string>() { "Randy", "Tom", "Dick", "Harry", "Kevin", "Nevin", "Joe" };
            femaleNames = new List<string>() { "Linda", "Tia", "Lisa", "Kelli", "Kali", "Taylor", "Deanna" };

            namePicker = new Random();
        }

        // member methods
        // Sets the name with title.  e.g. Grandpa Dick
        public abstract void SetName(string name);

        // Decide if customer will buy lemonade based on weather, recipe, and personal preferences.
        public abstract bool BuysLemonade(Weather weather, Recipe recipe);
    }
}
