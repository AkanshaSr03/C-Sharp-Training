using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPract
{
    class InRefOut
    {
  
      public static void Sum(out int a, out int b)
        {
            a = 2;
            b = 5;
            int s = a + b;
            Console.WriteLine($"sum of {a} and {b} is {s}");
        }
    }
    
}
