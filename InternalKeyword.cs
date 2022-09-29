using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPract
{
    class InternalKeyword
    {
       
        internal int  swapTwoNumber(int a, int b)
        {
          a=a+b;
            b=a-b;
            a=a-b;
            Console.WriteLine($"Number after swapping: a= { a}, b= { b}");
            return a;

        }
    }
}
