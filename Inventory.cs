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
        public void PurchaseItems(Store store, Wallet wallet)
        {

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
