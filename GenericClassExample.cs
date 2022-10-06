// See https://aka.ms/new-console-template for more information
using System;

namespace Generics
{
    class GenericClass<T>
    {
      public GenericClass(T msg)
        {
            Console.WriteLine(msg);
        }
    }

    class Genericxamples
    {
        public static void Main(string[] args)
        {
            GenericClass<string> genC = new GenericClass<string>("This is Generic class");
            GenericClass<int> genCi = new GenericClass<int>(23);
            GenericClass<char> genCh = new GenericClass<char>('A');
            GenericMethodExample example = new GenericMethodExample();
            example.GenericMethod("This is Generic Method");
            example.GenericMethod(123);
            example.GenericMethod('S');
            var stack = new SimpleStack<double>();
            stack.Push(1.7);
            stack.Push(2.3);
            stack.Push(3.0);
            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item: {item}");
                sum += item;
            }
            Console.WriteLine($"Sum is: {sum}");
            Console.ReadLine();

        }
    }
}
