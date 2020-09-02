using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = PrintFibonacci(4);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Case 2");
            list = PrintFibonacci(6);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Case 3");
            list = PrintFibonacci(10);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> PrintFibonacci(int num)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < num; i++)
            {
                int fib = FibonacciSequence(i);
                list.Add(fib);
            }

            return list;
        }



        static int FibonacciSequence(int n)
        {
            if (n == 0)
                return 0;
            else if (n <= 2)
                return 1;
            else
                return FibonacciSequence(n - 1) + FibonacciSequence(n - 2);
        }
    }
}
