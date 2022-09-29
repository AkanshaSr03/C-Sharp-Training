// See https://aka.ms/new-console-template for more information
using System;
using MaxMinMethods;
using MethodsPract;


namespace MaxMinMethods 
{
    class NumberManipulator 
    {
        public int  FindMax(int a, int b, int c)
        {  if(a>b && a>c)
            return a;
          else if(b>c)
                return b;
        else
                return c;
        }

        public static void Main(string[] args)
        {
            int a = 3;
            int b = 14;
            int c = 5;
            NumberManipulator max = new NumberManipulator();
            int maxres = max.FindMax(a, b, c);
            Console.WriteLine("Max value is: {0}", maxres);
            //We can also call public method from other classes by using the instance of the class.
            //For example, the method FindMax belongs to the NumberManipulator class,
            //we can call it from another class Test.
            //CallingAMethodOfAnotherClass min = new CallingAMethodOfAnotherClass(); 
            int minres = CallingAMethodOfAnotherClass.FindMin(a, b, c);
            Console.WriteLine("Min value is: {0}", minres);
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            Factorial.FactorialOfNum(n);
            int facResult = RecursiveFactorial.recursiveFactorial(n);
            Console.WriteLine("Factorial of {0} in recursive way is {1}", n, facResult);
            int num1,num2;
            Console.WriteLine("Enter two number to swap");
             num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            //var  arr = Console.ReadLine().Split(' ');
            InternalKeyword internalkey = new InternalKeyword();
            int internalreturn= internalkey.swapTwoNumber(num1, num2);
            Console.WriteLine(internalreturn);
            int n1 = 4;
            int n2;
            InRefOut.Sum(out n1, out n2);
            Console.WriteLine($"sum of {n1} and {n2}"); //Its showing 2 and 5 in n1 and n2 





            //var p = Console.ReadLine().split(' ');
        }
    }

}

