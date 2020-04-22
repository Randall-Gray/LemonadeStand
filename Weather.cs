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
        private string condition;
        public string Condition 
        {
            get { return condition; }
        }

        private int temperature;
        public int Temperature
        {
            get { return temperature; }
        }

        static private List<string> weatherConditions;

        static private Random weatherForcaster;

        // constructor
        static Weather()
        {
            weatherConditions = new List<string>() { "Rain", "Hazy", "Cloudy", "Sunny and Clear" };

            weatherForcaster = new Random();
        }
        public Weather()
        {
            SetCurrentWeather();
        }

        // member methods
        // Allow weather to change during the day.
        public void SetCurrentWeather()
        {
            condition = weatherConditions[weatherForcaster.Next(0, weatherConditions.Count - 1)];
            temperature = weatherForcaster.Next(Constants.weatherMinTemp, Constants.weatherMaxTemp);
        }

        // Forcast future weather.
        public Weather ForcastWeather()
        {
            Weather weatherForcast = new Weather();

            weatherForcast.condition = weatherConditions[weatherForcaster.Next(0, weatherConditions.Count - 1)];
            weatherForcast.temperature = weatherForcaster.Next(Constants.weatherMinTemp, Constants.weatherMaxTemp);

            return weatherForcast;
        }
    }
}
