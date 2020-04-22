using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        // member methods
        static public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Let's play \"Lemonade Stand\"\n");
        }

        static public string GetPlayerName()
        {
            Console.WriteLine("Enter player name: ");
            return Console.ReadLine();
        }

        static public int GetNumberOfDays()
        {
            bool userInputIsAnInteger = false;
            int numberOfDays = -1;

            while (!userInputIsAnInteger || numberOfDays < 0)
            {
                Console.WriteLine("\nHow many days would you like to play?");
                Console.WriteLine("Please enter a positive integer (or 0):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out numberOfDays);
            }

            return numberOfDays;
        }

        // Get number of items to buy from the store.
        static public int GetNumberOfItemsToBuy(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("\nHow many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }

        // Get number of items for recipe.
        static public int GetNumberOfItemsForRecipe(string recipeItem, int origAmount)
        {
            string userInput;
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("\nHow many " + recipeItem + " would you like in the recipe?");
                Console.WriteLine("Please enter a positive integer (or 0):");
                Console.WriteLine("(<Enter> to leave unchanged)");

                userInput = Console.ReadLine();

                if (userInput == "")        // User didn't change number of items.
                {
                    quantityOfItem = origAmount;
                    userInputIsAnInteger = true;
                }
                else
                    userInputIsAnInteger = Int32.TryParse(userInput, out quantityOfItem);
            }

            return quantityOfItem;
        }

        static public double GetPricePerCup(double origPrice)
        {
            string userInput;
            bool userInputIsADouble = false;
            double cupPrice = -1;

            while (!userInputIsADouble || cupPrice < 0)
            {
                Console.WriteLine("\nHow much would you like to charge for a cup of lemonade?");
                Console.WriteLine("Please enter a positive dollar amount ($x.xx):");
                Console.WriteLine("(<Enter> to leave unchanged)");

                userInput = Console.ReadLine();

                if (userInput == "")        // User didn't change price.
                {
                    cupPrice = origPrice;
                    userInputIsADouble = true;
                }
                else
                    userInputIsADouble = double.TryParse(userInput, out cupPrice);
            }

            return cupPrice;
        }

        static public void DisplayWeather(Weather weather)
        {
            Console.WriteLine("\t" + weather.Condition + "\t" + weather.Temperature + "(F)");
        }

        // Display weather forcast (not actual weather) for entire length of game.
        static public void DisplayEntireWeatherForcast(List<Day> days)
        {
            Console.WriteLine("\nWeather Forcast");
            for (int i = 0; i < days.Count; i++)
            {
                Console.Write("Forcasted weather for day " + (i+1) + ":");
                UserInterface.DisplayWeather(days[i].weather.ForcastWeather());
            }
            Console.ReadLine();
        }

        static public void DisplayStoreSale(double transactionAmount, double moneyLeft)
        {
            Console.WriteLine("Cost: {0:C}\tRemaining Money: {1:C}", transactionAmount, moneyLeft);
        }

        static public void DisplayStoreNoSale(double transactionAmount)
        {
            Console.WriteLine("Not enough money. Cost: {0:C}", transactionAmount);
        }

        static public void DisplayRecipe(Recipe recipe, double costPerCup)
        {
            Console.WriteLine("\nLemonade Recipe");
            Console.WriteLine("Lemons (per pitcher):     \t" + recipe.amountOfLemons);
            Console.WriteLine("Sugar Cubes (per pitcher):\t" + recipe.amountOfSugarCubes);
            Console.WriteLine("Ice Cubes (per cup):      \t" + recipe.amountOfIceCubes);

            Console.WriteLine("\nCost per cup: {0:C}", costPerCup);
            Console.WriteLine("Price per cup: {0:C}\n", recipe.pricePerCup);
        }

        static public void DisplayMoneyInWallet(Player player)
        {
            Console.WriteLine("\nMoney: {0:C}", player.wallet.Money);
        }

        static public void DisplayMoneySpent(double money)
        {
            Console.WriteLine("\nMoney Spent: {0:C}", money);
        }

        static public void DisplayInventory(Inventory inventory, Store store)
        {
            Console.WriteLine("\nPlayer Inventory");
            Console.WriteLine("Lemons      ({0:C} ea) :\t{1}", store.pricePerLemon, inventory.lemons.Count);
            Console.WriteLine("Sugar Cubes ({0:C} ea) :\t{1}", store.pricePerSugarCube, inventory.sugarCubes.Count);
            Console.WriteLine("Ice Cubes   ({0:C} ea) :\t{1}", store.pricePerIceCube, inventory.iceCubes.Count);
            Console.WriteLine("Paper Cups  ({0:C} ea) :\t{1}", store.pricePerCup, inventory.cups.Count);
        }

        static public void DisplayItemsSpoiled(string item, int numSpoiled)
        {
            Console.WriteLine(numSpoiled +  " " +  item + " spoiled and have been removed from the inventory");
        }

        static public void DisplayItemsMelted(string item, int numMelted)
        {
            Console.WriteLine(numMelted + " " + item + " melted and have been removed from the inventory");
        }


        static public void DisplaySuppliesLine(Player player)
        {
            Console.WriteLine("Lemons: " + player.inventory.lemons.Count + 
                              "; Sugar Cubes: " + player.inventory.sugarCubes.Count +
                              "; Ice Cubes: " + player.inventory.iceCubes.Count +
                              "; Paper Cups: " + player.inventory.cups.Count +
                              " Cups in Pitcher: " + player.pitcher.cupsLeftInPitcher);
        }

        static public void DisplayDayHeader(string dayDesc, string playerName, int currentDay, int totalDays, Weather todayWeather, Weather tomorrowWeather)
        {
            Console.Clear();
            Console.WriteLine(playerName + "'s Lemonade Stand");
            Console.WriteLine("\nDay " + (currentDay + 1) + " of " + totalDays + "   (" + dayDesc + ")");
            Console.Write("Today's Weather: ");
            DisplayWeather(todayWeather);
            Console.Write("Tomorrow's Forcast: ");
            DisplayWeather(tomorrowWeather);
        }

        static public void DisplayDayGameStats(int day, double currentMoney, double startMoney)
        {
            Console.WriteLine("\nTotal Profit after day {0}: Money: {1:C} Profit: {2:C}", day, currentMoney, currentMoney - startMoney);
            Console.ReadLine();
        }

        static public void DisplayCustomerHeader()
        {
            Console.WriteLine("\nCustomers: ");
        }

        static public void DisplaySoldOut()
        {
            Console.WriteLine("SOLD OUT!  SORRY!");
        }

        static public void DisplayCustomerChoice(string name, bool boughtLemonade)
        {
            if (boughtLemonade)
                Console.WriteLine(name + " bought lemonade.");
            else
                Console.WriteLine(name + " passed by.");
        }

        static public void DisplayDaySales(int numCustomers, double numSales, double moneySpent, double moneyMade)
        {
            Console.WriteLine("\nCustomers: {0}\tSales: {1}\tCash In: {2:C}\tCash Out: {3:C}\tProfit: {4,C}", numCustomers, numSales, moneyMade, moneySpent, moneyMade-moneySpent);
        }

        static public void DisplayEndGameStats(int days, double currentMoney, double startMoney)
        {
            Console.WriteLine("\nGAME OVER!");
            Console.WriteLine("Total Profit after {0} days: Money: {1:C} Profit: {2:C}", days, currentMoney, currentMoney - startMoney);
        }

        // Ask user a Yes or No question e.g. "Everything okay", "Play again"
        static public bool AskUserYesOrNo(string question)
        {
            bool rtnAns;

            Console.WriteLine("\n" + question + "? (Y/N)");
            rtnAns = Console.ReadLine().ToUpper() == "Y";
            if (rtnAns)
                Console.Clear();
            return rtnAns;
        }
    }
}
