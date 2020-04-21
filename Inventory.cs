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

            for (int i = 0; i < lemons.Count; i++)
            {
                if (lemons[i].Spoiled())
                {
                    lemons.RemoveAt(i);
                    spoiledItems++;
                }
            }
            if (spoiledItems > 0)
                UserInterface.DisplayItemsSpoiled("lemons", spoiledItems);
        }

        private void CheckForSpoiledSugarCubes()
        {
            int spoiledItems = 0;

            for (int i = 0; i < sugarCubes.Count; i++)
            {
                if (sugarCubes[i].Spoiled())
                {
                    sugarCubes.RemoveAt(i);
                    spoiledItems++;
                }
            }
            if (spoiledItems > 0)
                UserInterface.DisplayItemsSpoiled("sugar cubes", spoiledItems);
        }

        private void CheckForSpoiledIceCubes()
        {
            int spoiledItems = 0;

            for (int i = 0; i < iceCubes.Count; i++)
            {
                if (iceCubes[i].Spoiled())
                {
                    iceCubes.RemoveAt(i);
                    spoiledItems++;
                }
            }
            if (spoiledItems > 0)
                UserInterface.DisplayItemsSpoiled("ice cubes", spoiledItems);
        }

        private void CheckForSpoiledCups()
        {
            int spoiledItems = 0;

            for (int i = 0; i < cups.Count; i++)
            {
                if (cups[i].Spoiled())
                {
                    cups.RemoveAt(i);
                    spoiledItems++;
                }
            }
            if (spoiledItems > 0)
                UserInterface.DisplayItemsSpoiled("paper cups", spoiledItems);
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
