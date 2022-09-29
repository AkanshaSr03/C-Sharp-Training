using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPract
{
     class Factorial
    {
        public static void FactorialOfNum(int num)
        { int number = num;
            int fact = 1;
            while (num > 0)
            {
                fact *= num;
                num -= 1;
            }
            Console.WriteLine("Factorial of {0} is {1}", number, fact);
        }
    }
}
