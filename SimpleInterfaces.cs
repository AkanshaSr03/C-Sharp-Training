using System;
using Interfaces;

namespace Interfaces
{
   interface CakeFlavour
    {
        void cakeFlavour();
    }
    class Cake : CakeFlavour
    {
        public void cakeFlavour()
        {
            Console.WriteLine("Dark chocolate Cake");
        } 
        
        
    }
    class SimpleInterfaces
    {
        public static void Main(String[] args)
        {
          Cake cake = new Cake();
            cake.cakeFlavour();
            Birthday item = new Birthday();
            item.foodItem();
            item.decorativeItem();
            UserInput input = new UserInput();
            Console.WriteLine("Enter you ID");
            int id = Convert.ToInt32(Console.ReadLine());
            id = input.userInput(id);
            Console.WriteLine(id);
        }
    }


}
