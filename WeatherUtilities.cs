using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities
{
    class WeatherUtilities
    { 
        public static float CelciusToFaharenheit(float tempCelcius)
        {
            var tempFarahenheit = tempCelcius * 1.8f + 32;
            return tempFarahenheit;
        }
        public static float FaharenheitToCelcius(float faharenheit)
        {
            /*float celcius=(Faharenheit-32)/ 1.8f; 32 converted to 32.0
             *reurn celcius
             */
            //Type Inference
            return (float)((faharenheit - 32) / 1.8f);
        }

        public static void Report(string location, float temperatureCelcius, float temperatureFaharenheit)
        {
            var farahenheit = CelciusToFaharenheit(temperatureCelcius) ;
            var celcius = FaharenheitToCelcius(temperatureFaharenheit);
            Console.WriteLine($" is: {location},{ farahenheit}, {celcius}");
        }
    }
}
