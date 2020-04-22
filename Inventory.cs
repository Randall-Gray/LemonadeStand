using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Inventory
    {
        // member variables
        public List<Lemon> lemons;
        public List<SugarCube> sugarCubes;
        public List<IceCube> iceCubes;
        public List<Cup> cups;

        // constructor
        public Inventory()
        {
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube>();
            iceCubes = new List<IceCube>();
            cups = new List<Cup>();
        }

        // member methods
        public double PurchaseItems(Store store, Player player)
        {
            double startMoney = player.wallet.Money;

            UserInterface.DisplayMoneyInWallet(player);
            UserInterface.DisplayInventory(this, store);
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);
            UserInterface.DisplayMoneySpent(startMoney - player.wallet.Money);
            UserInterface.DisplayMoneyInWallet(player);
            UserInterface.DisplayInventory(this, store);

            return startMoney - player.wallet.Money;    // Money spent 
        }

        // Remove and report any spoiled inventory
        public void CheckForSpoilage()
        {
            CheckForSpoiledLemons();
            CheckForSpoiledSugarCubes();
            CheckForSpoiledIceCubes();
            CheckForSpoiledCups();
        }

        private void CheckForSpoiledLemons()
        {
            int spoiledItems = 0;

            for (int i = lemons.Count - 1; i >= 0; i--)          // Set count first since removing items from list in loop.
            {
                if (lemons[i].Spoiled())
                {
                    lemons.RemoveAt(i);
                    spoiledItems++;
                }
            }
            if (spoiledItems > 0)
                UserInterface.DisplayItemsSpoiled("lemon(s)", spoiledItems);
        }

        private void CheckForSpoiledSugarCubes()
        {
            int spoiledItems = 0;

            for (int i = sugarCubes.Count - 1; i >= 0; i--)          // Set count first since removing items from list in loop.
            {
                if (sugarCubes[i].Spoiled())
                {
                    sugarCubes.RemoveAt(i);
                    spoiledItems++;
                }
            }
            if (spoiledItems > 0)
                UserInterface.DisplayItemsSpoiled("sugar cube(s)", spoiledItems);
        }

        private void CheckForSpoiledIceCubes()
        {
            int spoiledItems = 0;

            for (int i = iceCubes.Count - 1; i >= 0; i--)   // Set count first since removing items from list in loop.
            {
                if (iceCubes[i].Spoiled())
                {
                    iceCubes.RemoveAt(i);
                    spoiledItems++;
                }
            }
            if (spoiledItems > 0)
                UserInterface.DisplayItemsMelted("ice cube(s)", spoiledItems);
        }

        private void CheckForSpoiledCups()
        {
            int spoiledItems = 0;

            for (int i = cups.Count - 1; i >= 0; i--)            // Set count first since removing items from list in loop.
            {
                if (cups[i].Spoiled())
                {
                    cups.RemoveAt(i);
                    spoiledItems++;
                }
            }
            if (spoiledItems > 0)
                UserInterface.DisplayItemsSpoiled("paper cup(s)", spoiledItems);
        }

        public void AddLemonsToInventory(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubesToInventory(int numberOfSugarCubes)
        {
            for(int i = 0; i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubesToInventory(int numberOfIceCubes)
        {
            for(int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCupsToInventory(int numberOfCups)
        {
            for(int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }

        public bool RemoveLemonsFromInventory(int numberOfLemons)
        {
            bool enoughLemons = lemons.Count >= numberOfLemons;

            if (enoughLemons)
            {
                for (int i = 0; i < numberOfLemons; i++)
                    lemons.RemoveAt(0);
            }

            return enoughLemons;
        }

        public bool RemoveSugarCubesFromInventory(int numberOfSugarCubes)
        {
            bool enoughSugarCubes = sugarCubes.Count >= numberOfSugarCubes;

            if (enoughSugarCubes)
            {
                for (int i = 0; i < numberOfSugarCubes; i++)
                    sugarCubes.RemoveAt(0);
            }

            return enoughSugarCubes;
        }

        public bool RemoveIceCubesFromInventory(int numberOfIceCubes)
        {
            bool enoughIceCubes = iceCubes.Count >= numberOfIceCubes;

            if (enoughIceCubes)
            {
                for (int i = 0; i < numberOfIceCubes; i++)
                    iceCubes.RemoveAt(0);
            }

            return enoughIceCubes;
        }

        public bool RemoveCupsFromInventory(int numberOfCups)
        {
            bool enoughCups = cups.Count >= numberOfCups;

            if (enoughCups)
            {
                for (int i = 0; i < numberOfCups; i++)
                    cups.RemoveAt(0);
            }

            return enoughCups;
        }
    }
}
