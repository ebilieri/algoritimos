using System;
using System.Collections.Generic;

namespace BalancedSumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3, 3 };
            int r = BalancedSum(arr);
            Console.WriteLine(r);

            arr = new List<int> { 1, 2, 1 };
            r = BalancedSum(arr);
            Console.WriteLine(r);

            arr = new List<int> { 1, 2, 1, 3, 4, 3, 6, 7, 8, 9, 9, 9 };
            r = BalancedSum(arr);
            Console.WriteLine(r);
        }

        public static int BalancedSum(List<int> arr)
        {
            int size = arr.Count;
            int sumRight = 0;
            int sumLeft = arr[0];

            // sum right items array
            for (int i = 2; i < size; i++)
            {
                sumRight += arr[i];
            }

            if (sumLeft == sumRight)
            {
                return 1;
            }
            else
            {
                for (int i = 2; i < size - 1; i++)
                {
                    sumLeft += arr[i - 1];
                    sumRight -= arr[i];

                    if (sumLeft == sumRight)
                        return i;
                }
            }

            return -1;
        }
    }
}
