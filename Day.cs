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
        public double moneySpent;
        public double moneyMade;

        public Weather weather;
        public List<Customer> customers;

        static private List<string> customerTypes;
        static private Random customerSelector;

        // constructor
        public Day()
        {
            moneySpent = 0;
            moneyMade = 0;

            weather = new Weather();
            customers = new List<Customer>();
            customerTypes = new List<string>() { "Grandpa", "Grandma", "Mailman", "Nurse", "Business Man", "Business Woman", "Boy", "Girl", "Boyscout", "Girlscout", "Baby" };

            customerSelector = new Random();

            InitializeCustomers();
        }

        // member methods
        public void RunDay(Player player)
        {
            bool soldOut = false;
            double customerSales = 0;

            UserInterface.DisplayCustomerHeader();

            for (int i = 0; i < customers.Count; i++)
            {
                if (player.pitcher.cupsLeftInPitcher == 0)
                {
                    soldOut = !player.MakePitcherOfLemonade();      // Out of ingredients
                }

                if (player.inventory.cups.Count == 0)               // Out of cups
                    soldOut = true;

                UserInterface.DisplaySuppliesLine(player);
                if (!soldOut && customers[i].BuysLemonade(weather, player.recipe))
                {
                    if (player.PourLemonade())
                    {
                        player.wallet.PocketMoneyFromSales(player.recipe.pricePerCup);
                        customerSales++;
                        UserInterface.DisplayCustomerChoice(customers[i].name, true);
                        continue;
                    }
                }
                UserInterface.DisplayCustomerChoice(customers[i].name, false);
            }
            moneyMade = customerSales * player.recipe.pricePerCup;
            UserInterface.DisplayDaySales(customers.Count, customerSales, moneySpent, moneyMade);
            
            player.inventory.CheckForSpoilage();
        }

        // Number of customers depends on weather.  Customer type is random.
        private void InitializeCustomers()
        {
            string customerType; 
            Customer customer = null;
            int numberOfCustomers = NumberOfCustomers();

            for (int i = 0; i < numberOfCustomers; i++)
            {
                customerType = customerTypes[customerSelector.Next(0, customerTypes.Count)];

                switch(customerType)
                {
                    case "Grandpa":
                        customer = new Grandpa();
                        break;
                    case "Grandma":
                        customer = new Grandma();
                        break;
                    case "Mailman":
                    case "Business Man":
                        customer = new Man();
                        break;
                    case "Nurse":
                    case "Business Woman":
                        customer = new Woman();
                        break;
                    case "Boy":
                    case "Boyscout":
                        customer = new Boy();
                        break;
                    case "Girl":
                    case "Girlscout":
                        customer = new Girl();
                        break;
                    case "Baby":
                        customer = new Baby();
                        break;
                    default:
                        break;
                }
                if (customer != null)
                {
                    customer.SetName(customerType);
                    customers.Add(customer);
                }
            }
        }

        // Number of customers is the day's temperature modified based on weather condition.
        private int NumberOfCustomers()
        {
            int numberOfCustomers = weather.Temperature;

            switch (weather.Condition)
            {
                case "Rain":
                    numberOfCustomers = numberOfCustomers / 10 * Constants.weatherRainPercent;
                    break;
                case "Hazy":
                    numberOfCustomers = numberOfCustomers / 10 * Constants.weatherHazyPercent;
                    break;
                case "Cloudy":
                    numberOfCustomers = numberOfCustomers / 10 * Constants.weatherCloudyPercent;
                    break;
                default:        // Sunny and Clear
                    break;
            };

            return numberOfCustomers;
        }
    }
}
