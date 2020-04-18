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
        public static void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Let's play \"Lemonade Stand\"\n");
        }

        public static string GetPlayerName()
        {
            Console.WriteLine("Enter player name: ");
            return Console.ReadLine();
        }

        public static int GetNumberOfDays()
        {
            bool userInputIsAnInteger = false;
            int numberOfDays = -1;

            while (!userInputIsAnInteger || numberOfDays < 0)
            {
                Console.WriteLine("How many days would you like to play?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out numberOfDays);
            }

            return numberOfDays;
        }

        // Get number of item to buy from the store.
        public static int GetNumberOfItemsToBuy(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
    }
}
