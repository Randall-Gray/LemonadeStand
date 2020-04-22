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
        static Day()
        {
            customerTypes = new List<string>() { "Grandpa", "Grandma", "Mailman", "Nurse", "Business Man", "Business Woman", "Boy", "Girl", "Boyscout", "Girlscout", "Baby" };

            customerSelector = new Random();
        }

        public Day()
        {
            moneySpent = 0;
            moneyMade = 0;

            weather = new Weather();
            customers = new List<Customer>();

            InitializeCustomers();
        }

        // member methods
        public void RunDay(Player player)
        {
            int numCups;
            bool soldOut = false;
            double customerSales = 0;

            UserInterface.DisplayCustomerHeader();

            for (int i = 0; i < customers.Count; i++)
            {
                numCups = 0;    // Number of cups a customer wants.  They may ask for more than one.

                do
                {
                    if (player.pitcher.cupsLeftInPitcher == 0)
                    {
                        soldOut = !player.MakePitcherOfLemonade();      // Out of ingredients - lemons and sugar cubes
                    }

                    if (player.inventory.cups.Count == 0 ||               // Out of cups
                        player.inventory.iceCubes.Count < player.recipe.amountOfIceCubes)   // Out of ice
                        soldOut = true;

                    UserInterface.DisplaySuppliesLine(player);
                    if (!soldOut && numCups == 0)
                        numCups = customers[i].BuysLemonade(weather, player.recipe);
                    if (!soldOut && numCups > 0)
                    {
                        if (player.PourLemonade())      // Can't actually fail since inventory is already checked
                        {
                            player.wallet.PocketMoneyFromSales(player.recipe.pricePerCup);
                            customerSales++;
                            numCups--;
                            UserInterface.DisplayCustomerChoice(customers[i].name, true);
                            continue;
                        }
                    }
                    if (soldOut)
                    {
                        UserInterface.DisplaySoldOut();
                        numCups = 0;    
                    }
                    UserInterface.DisplayCustomerChoice(customers[i].name, false);
                } 
                while (numCups > 0);        // Customer asking for more than 1 cup, goes through line again.
            }
            UserInterface.DisplaySuppliesLine(player);      // Display the final supply list.

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
