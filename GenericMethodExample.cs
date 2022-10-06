using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericMethodExample
    {
        public void GenericMethod<T>(T msg)
        {
            Console.WriteLine(msg);
        }
    }
}
