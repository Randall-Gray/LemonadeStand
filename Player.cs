using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables
        public string name;

        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;

        // constructor
        public Player(string name)
        {
            this.name = name;
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            pitcher = new Pitcher();
        }

        // member methods
        public bool MakePitcherOfLemonade()
        {
            if (inventory.lemons.Count >= recipe.amountOfLemons &&
                inventory.sugarCubes.Count >= recipe.amountOfSugarCubes &&
                inventory.iceCubes.Count >= recipe.amountOfIceCubes)
            {
                pitcher.cupsLeftInPitcher = pitcher.maxCupsInPitcher;

                inventory.RemoveLemonsFromInventory(recipe.amountOfLemons);
                inventory.RemoveSugarCubesFromInventory(recipe.amountOfSugarCubes);
                inventory.RemoveIceCubesFromInventory(recipe.amountOfIceCubes);
                
                return true;
            }
            return false;
        }
        public bool PourLemonade()
        {
            if (inventory.cups.Count >= 1 && pitcher.cupsLeftInPitcher >= 1)
            {
                inventory.RemoveCupsFromInventory(1);
                pitcher.cupsLeftInPitcher--;
                return true;
            }

            return false;
        }
    }
}
