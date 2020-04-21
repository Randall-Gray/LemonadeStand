using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class Constants
    {
        // Magic numbers used in Lemonade program
        // Wallet
        static public double walletStartMoney { get; } = 20.00;

        // Weather
        static public int weatherMinTemp { get; } = 50;
        static public int weatherMaxTemp { get; } = 100;

        // Percent (*10%) of customers per weather condition
        static public int weatherRainPercent { get; } = 4;
        static public int weatherHazyPercent { get; } = 6;
        static public int weatherCloudyPercent { get; } = 8;

        // Store
        static public double storePricePerLemon { get; } = .5;
        static public double storePricePerSugarCube { get; } = .1;
        static public double storePricePerIceCube { get; } = .01;
        static public double storePricePerCup { get; } = .25;

        // Inventory
        static public int daysToSpoilLemon { get; } = 3;
        static public int daysToSpoilSugarCube { get; } = 365;
        static public int daysToSpoilIceCube { get; } = 1;          // Ice melts away every day.
        static public int daysToSpoilCup { get; } = 2000;

        // Pitcher
        static public int maxCupsInPitcher { get; } = 12;

        // Customer Man
        static public double manMaxPrice { get; } = 1.00;
        static public int manMinTemp { get; } = 50;
        static public int manMinIce { get; } = 2;
        static public int manMoreIceTemp { get; } = 70;
        static public int manMinIceHot { get; } = 3;

        // Customer Woman
        static public double womanMaxPrice { get; } = .90;
        static public int womanMinTemp { get; } = 60;
        static public int womanMinIce { get; } = 2;
        static public int womanMoreIceTemp { get; } = 80;
        static public int womanMinIceHot { get; } = 3;

        // Customer Grandpa
        static public double grandpaMaxPrice { get; } = .60;
        static public int grandpaMinTemp { get; } = 60;
        static public int grandpaMinIce { get; } = 1;
        static public int grandpaMoreIceTemp { get; } = 85;
        static public int grandpaMinIceHot { get; } = 3;

        // Customer Grandma
        static public double grandmaMaxPrice { get; } = .50;
        static public int grandmaMinTemp { get; } = 60;
        static public int grandmaMinIce { get; } = 1;
        static public int grandmaMoreIceTemp { get; } = 85;
        static public int grandmaMinIceHot { get; } = 3;

        // Customer Boy
        static public double boyMaxPrice { get; } = .40;
        static public int boyMinIce { get; } = 1;

        // Customer Girl
        static public double girlMaxPrice { get; } = .40;
        static public int girlMinIce { get; } = 1;
    }
}
