using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Wallet
    {
        // member variables
        private double money;

        // assossor methods
        public double Money
        {
            get
            {
                return money;
            }
        }

        // constructor
        public Wallet(double startMoney = 20.00)
        {
            money = startMoney;
        }

        // member methods
        public void PayMoneyForItems(double transactionAmount)
        {
            money -= transactionAmount;
        }

        public void PocketMoneyFromSales(double moneyFromSales)
        {
            money += moneyFromSales;
        }
    }
}
