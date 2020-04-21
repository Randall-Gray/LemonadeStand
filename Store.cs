using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Store
    {
        // member variables
        // assume Store has an infinite amount of each item.
        public double pricePerLemon { get; }
        public double pricePerSugarCube { get; }
        public double pricePerIceCube { get; }
        public double pricePerCup { get; }

        // constructor
        public Store()
        {
            pricePerLemon = Constants.storePricePerLemon;
            pricePerSugarCube = Constants.storePricePerSugarCube;
            pricePerIceCube = Constants.storePricePerIceCube;
            pricePerCup = Constants.storePricePerCup;
        }

        // member methods
        public void SellLemons(Player player)
        {
            bool validPurchase = false;
            int lemonsToPurchase;
            double transactionAmount;

            do
            {
                lemonsToPurchase = UserInterface.GetNumberOfItemsToBuy("lemons");
                transactionAmount = CalculateTransactionAmount(lemonsToPurchase, pricePerLemon);

                validPurchase = player.wallet.Money >= transactionAmount;
                if (validPurchase)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddLemonsToInventory(lemonsToPurchase);
                    UserInterface.DisplayStoreSale(transactionAmount, player.wallet.Money);
                }
                else
                    UserInterface.DisplayStoreNoSale(transactionAmount);

            } while (!validPurchase);
        }

        public void SellSugarCubes(Player player)
        {
            bool validPurchase = false;
            int sugarToPurchase;
            double transactionAmount;

            do
            {
                sugarToPurchase = UserInterface.GetNumberOfItemsToBuy("sugar cubes");
                transactionAmount = CalculateTransactionAmount(sugarToPurchase, pricePerSugarCube);

                validPurchase = player.wallet.Money >= transactionAmount;
                if (validPurchase)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddSugarCubesToInventory(sugarToPurchase);
                    UserInterface.DisplayStoreSale(transactionAmount, player.wallet.Money);
                }
                else
                    UserInterface.DisplayStoreNoSale(transactionAmount);

            } while (!validPurchase);
        }

        public void SellIceCubes(Player player)
        {
            bool validPurchase = false;
            int iceCubesToPurchase;
            double transactionAmount;

            do
            {
                iceCubesToPurchase = UserInterface.GetNumberOfItemsToBuy("ice cubes");
                transactionAmount = CalculateTransactionAmount(iceCubesToPurchase, pricePerIceCube);

                validPurchase = player.wallet.Money >= transactionAmount;
                if (validPurchase)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddIceCubesToInventory(iceCubesToPurchase);
                    UserInterface.DisplayStoreSale(transactionAmount, player.wallet.Money);
                }
                else
                    UserInterface.DisplayStoreNoSale(transactionAmount);

            } while (!validPurchase);
        }

        public void SellCups(Player player)
        {
            bool validPurchase = false;
            int cupsToPurchase;
            double transactionAmount;

            do
            {
                cupsToPurchase = UserInterface.GetNumberOfItemsToBuy("cups");
                transactionAmount = CalculateTransactionAmount(cupsToPurchase, pricePerCup);

                validPurchase = player.wallet.Money >= transactionAmount;

                if (validPurchase)
                {
                    PerformTransaction(player.wallet, transactionAmount);
                    player.inventory.AddCupsToInventory(cupsToPurchase);
                    UserInterface.DisplayStoreSale(transactionAmount, player.wallet.Money);
                }
                else
                    UserInterface.DisplayStoreNoSale(transactionAmount);

            } while (!validPurchase);
        }

        private double CalculateTransactionAmount(int itemCount, double itemPricePerUnit)
        {
            double transactionAmount = itemCount * itemPricePerUnit;
            return transactionAmount;
        }

        private void PerformTransaction(Wallet wallet, double transactionAmount)
        {
            wallet.PayMoneyForItems(transactionAmount);
        }
    }
}
