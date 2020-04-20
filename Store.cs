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
        private double pricePerLemon;
        private double pricePerSugarCube;
        private double pricePerIceCube;
        private double pricePerCup;

        // constructor
        public Store()
        {
            pricePerLemon = .5;
            pricePerSugarCube = .1;
            pricePerIceCube = .01;
            pricePerCup = .25;
        }

        // member methods
        //public void SellItems(Player player)
        //{
        //    string item;



        //    do
        //    {
        //        //item = UserInterface.PickItemForPurchase();
        //        switch (item.ToUpper())
        //        {
        //            case "LEMONS":
        //                SellLemons(player);
        //                break;
        //            case "SUGARCUBES":
        //                SellSugarCubes(player);
        //                break;
        //            case "ICECUBES":
        //                SellIceCubes(player);
        //                break;
        //            case "CUPS":
        //                SellCups(player);
        //                break;
        //            default:
        //                break;
        //        }
        //    } while (true);
        //}

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
                    Console.WriteLine("Cost: {0:C}\tRemaining Money: {1:C}", transactionAmount, player.wallet.Money);
                }
                else
                    Console.WriteLine("Not enough money. Cost: {0:C}", transactionAmount);
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
                    Console.WriteLine("Cost: {0:C}\tRemaining Money: {1:C}", transactionAmount, player.wallet.Money);
                }
                else
                    Console.WriteLine("Not enough money. Cost: {0:C}", transactionAmount);
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
                    Console.WriteLine("Cost: {0:C}\tRemaining Money: {1:C}", transactionAmount, player.wallet.Money);
                }
                else
                    Console.WriteLine("Not enough money. Cost: {0:C}", transactionAmount);
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
                    Console.WriteLine("Cost: {0:C}\tRemaining Money: {1:C}", transactionAmount, player.wallet.Money);
                }
                else
                    Console.WriteLine("Not enough money. Cost: {0:C}", transactionAmount);
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
