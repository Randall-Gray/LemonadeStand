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
        private double startMoney;

        // assossor methods
        public double Money
        {
            get { return money; }
        }

        public double StartMoney
        {
            get { return startMoney; }
        }

        // constructor
        public Wallet(double startMoney)
        {
            this.startMoney = startMoney;
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
