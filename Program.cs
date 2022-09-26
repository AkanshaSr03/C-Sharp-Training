// See https://aka.ms/new-console-template for more information
using CloudCheck;
using MyUtilities;
using System;
namespace myFirstProgram
{ class Program
    {   static void Main(string[] args)
        {
            WeatherUtilities.Report("Patna ", 45, 56);
            WeatherCheck.Raining("cloudy");
            //float celcius=Program.FaharenheitToCelcius(132.5f);
            //Console.WriteLine(celcius);
            //Console.WriteLine("Hello, World!");
        }

       
        //bool weather = isRaining("cloudy");
        //Console.WriteLine("Weather is"+ weather);

       
    }
}