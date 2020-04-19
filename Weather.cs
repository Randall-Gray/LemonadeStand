using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        // member variables
        public string condition;
        public int temperature;
        private static List<string> weatherConditions;

        private static Random weatherForcaster;

        // constructor
        public Weather()
        {
            weatherConditions = new List<string>() {"Rain", "Hazy", "Cloudy", "Sunny and Clear"};

            weatherForcaster = new Random();

            SetCurrentWeather();
        }

        // member methods
        // Allow weather to change during the day.
        public void SetCurrentWeather()
        {
            condition = weatherConditions[weatherForcaster.Next(0, weatherConditions.Count - 1)];
            temperature = weatherForcaster.Next(50, 100);
        }

        public void DisplayWeather()
        {
            Console.WriteLine("Weather: " + condition + "\tTemperature: " + temperature + "(F)");
        }
    }
}
