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
        private List<string> weatherConditions;

        private Random weatherForcaster;

        // constructor
        public Weather()
        {
            weatherConditions = new List<string>() {"rain", "hazy", "cloudy", "Sunny and Clear" };

            weatherForcaster = new Random();

            SetCurrentWeather();
        }

        // member methods
        public void SetCurrentWeather()
        {
            condition = weatherConditions[weatherForcaster.Next(0, weatherConditions.Count - 1)];
            temperature = weatherForcaster.Next(50, 100);
        }
    }
}
