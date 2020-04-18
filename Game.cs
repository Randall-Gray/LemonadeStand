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
            currentDay = InitializeDays();



            Console.ReadLine();
        }

        // Gets number of days and initializes days list. Returns first day, 0 (no days - game over) or 1, based on user input.
        private int InitializeDays()
        {
            int numDays = UserInterface.GetNumberOfDays();

            for (int i = 0; i < numDays; i++)
                days.Add(new Day());

            if (numDays > 0)
                return 1;       // first day
            else
                return 0;
        }
    }
}
