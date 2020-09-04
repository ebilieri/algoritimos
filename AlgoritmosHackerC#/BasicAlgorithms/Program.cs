using System;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var solveM = SolveMeFirst(2, 3);
            Console.WriteLine(solveM);

            Console.WriteLine("Simple sum array");
            int[] inputArray = new int[] { 1, 2, 3, 4, 10, 11 };
            var sumArray = SimpleArraySum(inputArray);
            Console.WriteLine(sumArray);
        }


        static int SolveMeFirst(int a, int b)
        {
            return a + b;
        }

        static int SimpleArraySum(int[] ar)
        {
            int sum = 0;
            foreach (var item in ar)
            {
                sum += item;
            }

            return sum;
        }
    }
}
