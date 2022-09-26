using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCheck
{
    class WeatherCheck
    {
       public static void Raining (string WeatherStatus)
        {
            if (WeatherStatus == "Cloudy")
            {
                 Console.WriteLine("Its Raining");
            }
            else
            {
                Console.WriteLine("Its not Raining");
            }
        }
    }
}
