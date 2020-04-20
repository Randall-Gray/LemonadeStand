using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        // member variables
        private Player player;
        private List<Day> days;
        private int currentDay;
        private Store store;

        // constructor
        public Game()
        {
            days = new List<Day>();
            store = new Store();
        }

        // member methods
        public void RunGame()
        {
            UserInterface.Welcome();
            player = new Player(UserInterface.GetPlayerName());
            InitializeDays();

            for (; currentDay < days.Count; currentDay++)
            {
                DaySetup();

                DisplayDayHeader("Sell Lemonade");
                days[currentDay].RunDay(player);

                UserInterface.DisplayDayGameStats(currentDay + 1, player.wallet.Money, player.wallet.StartMoney);
            }

            UserInterface.DisplayEndGameStats(currentDay, player.wallet.Money, player.wallet.StartMoney);

            Console.ReadLine();
        }

        // Gets number of days and initializes days list and the currentDay.
        private void InitializeDays()
        {
            int numDays = UserInterface.GetNumberOfDays();

            for (int i = 0; i < numDays; i++)
                days.Add(new Day());

            currentDay = 0;
        }

        // Set up recipe and inventory for the day.
        private void DaySetup()
        {
            do
            {
                DisplayDayHeader("Recipe and Price");
                player.recipe.SetRecipeAndPrice();
            } while (!UserInterface.Continue());
            do
            {
                DisplayDayHeader("Inventory");
                player.inventory.PurchaseItems(store, player);
            } while (!UserInterface.Continue());
        }

        private void DisplayDayHeader(string setup)
        {
            Console.Clear();
            Console.WriteLine(player.name + "'s Lemonade Stand");
            Console.WriteLine("\nDay " + (currentDay + 1) + " of " + days.Count + "   (" + setup + ")");
            days[currentDay].weather.DisplayWeather();
        }

    }
}
