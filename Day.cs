using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        // member variables
        public Weather weather;
        public List<Customer> customers;

        private static Random customerSelector;

        // constructor
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();

            customerSelector = new Random;

            InitializeCustomers();
        }

        // member methods
        public void RunDay(Player player)
        {


        }

        // Number of customers depends on weather.  Customer type is random.
        private void InitializeCustomers()
        {
            List<string> customerType = new List<string>() { "grandpa", "grandma", "dad", "mom", "boy", "girl"};
            int numberOfCustomers = NumberOfCustomers();

            for (int i = 0; i < numberOfCustomers; i++)
            {

            }

        }

        // Number of customers is the day's temperature modified based on weather condition.
        private int NumberOfCustomers()
        {
            int numberOfCustomers = weather.temperature;

            switch (weather.condition)
            {
                case "Rain":
                    numberOfCustomers /= 2;
                    break;
                case "Hazy":
                    numberOfCustomers = numberOfCustomers / 10 * 7;
                    break;
                case "Cloudy":
                    numberOfCustomers = numberOfCustomers / 10 * 8;
                    break;
                default:        // Sunny and Clear
                    break;
            };

            return numberOfCustomers;
        }
    }
}
