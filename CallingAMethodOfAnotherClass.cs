using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MethodsPract
{
    class CallingAMethodOfAnotherClass
    { 
      public static int FindMin(int a, int b, int c)
        {
            if (a<b && a<c)
                return a;
            else if (b<c)   
                return b;
            else
                return c;
        }
    }
}
