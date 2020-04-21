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
                GetDayRecipeAndPrice();
                GetDayInventory();

                UserInterface.DisplayDayHeader("Sell Lemonade", player.name, currentDay, days.Count, days[currentDay].weather, days[currentDay].weather.ForcastWeather());
                days[currentDay].RunDay(player);

                UserInterface.DisplayDayGameStats(currentDay + 1, player.wallet.Money, player.wallet.StartMoney);
            }

            UserInterface.DisplayEndGameStats(currentDay, player.wallet.Money, player.wallet.StartMoney);
        }

        // Gets number of days and initializes days list and the currentDay.
        private void InitializeDays()
        {
            int numDays = UserInterface.GetNumberOfDays();

            for (int i = 0; i < numDays; i++)
                days.Add(new Day());

            currentDay = 0;
        }

        // Set up recipe and price for the day.
        private void GetDayRecipeAndPrice()
        {
            do
            {
                UserInterface.DisplayDayHeader("Recipe and Price", player.name, currentDay, days.Count, days[currentDay].weather, days[currentDay].weather.ForcastWeather());
                player.recipe.SetRecipeAndPrice(store);
            } while (UserInterface.AskUserYesOrNo("Everything okay") != true);
        }

        // Set up inventory for the day.
        private void GetDayInventory()
        {
            do
            {
                UserInterface.DisplayDayHeader("Inventory", player.name, currentDay, days.Count, days[currentDay].weather, days[currentDay].weather.ForcastWeather());
                days[currentDay].moneySpent += player.inventory.PurchaseItems(store, player);
            } while (UserInterface.AskUserYesOrNo("Everything okay") != true);
        }
    }
}
