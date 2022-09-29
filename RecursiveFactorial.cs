using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPract
{
    class RecursiveFactorial
    {
        public static int  recursiveFactorial(int n)
        {
            int fac=1;
            if (n == 1)
                return 1;
            else { 
                fac = n * recursiveFactorial(n - 1);
            }
            return fac;
        }
    }
}
