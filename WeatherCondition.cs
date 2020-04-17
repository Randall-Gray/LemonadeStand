using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class WeatherCondition
    {
        // member variables
        public string condition;
        public int temperature;

        // constructor
        public WeatherCondition(string condition, int temperature)
        {
            this.condition = condition;
            this.temperature = temperature;
        }

        public WeatherCondition(WeatherCondition weatherCondition)
        {
            condition = weatherCondition.condition;
            temperature = weatherCondition.temperature;
        }
    }
}
