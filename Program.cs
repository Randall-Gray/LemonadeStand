using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            Game lemonadeStand = new Game();        

            do
            {
                lemonadeStand.RunGame();

                if (UserInterface.AskUserYesOrNo("Would you like to play again") != true)
                    break;
            }
            while (true);

        }
    }
}
