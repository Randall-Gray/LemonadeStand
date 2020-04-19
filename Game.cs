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

            for (currentDay = 0; currentDay < days.Count; currentDay++)
            {
                Console.Clear();
                Console.WriteLine(player.name + "'s Lemonade Stand");
                Console.WriteLine("\nDay " + (currentDay + 1) + " of " + days.Count);
                days[currentDay].weather.DisplayWeather();
                player.recipe.SetRecipe();
                player.inventory.PurchaseItems(store, player.wallet);

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
    }
}
