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
        public WeatherCondition currentWeather;
        private List<WeatherCondition> weatherConditions;

        private Random weatherForcaster;

        // constructor
        public Weather()
        {
            weatherConditions = new List<WeatherCondition>();

            AddWeather("snow", 30);
            AddWeather("sleet", 32);
            AddWeather("hail", 50);
            AddWeather("rain", 55);
            AddWeather("hazy", 60);
            AddWeather("cloudy", 70);
            AddWeather("Sunny and Clear", 82);
            AddWeather("Hot", 95);

            weatherForcaster = new Random();

            // Set current weather condition
            currentWeather = new WeatherCondition(weatherConditions[weatherForcaster.Next(0, weatherConditions.Count - 1)]);
        }

        // member methods
        private void AddWeather(string condition, int temperature)
        {
            weatherConditions.Add(new WeatherCondition(condition, temperature));
        }

        public WeatherCondition PredictWeather()
        {
            return weatherConditions[weatherForcaster.Next(0, weatherConditions.Count - 1)];
        }
    }
}
