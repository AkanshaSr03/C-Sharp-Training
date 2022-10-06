using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Decoration
    {
        void decorativeItem();
        
    }
    interface Food
    {
        void foodItem();
    }

    class Birthday: Decoration, Food
    {
        public void decorativeItem()
        {
            Console.WriteLine("Decorative items are : balloons, ribbons, lights, ....");
        }
        public void foodItem()
        {
            Console.WriteLine("Available food items are : Cake, Sweets, Ice-cream, ....");
        }
    }

   
}
