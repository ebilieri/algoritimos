using System;

namespace LeftRotarionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int d = 2;
           
            int[] ret = LeftRotateNoPerformatic(arr, d);
            PrintArray(ret);

            Console.WriteLine("Case 2");
            arr = new int[] { 1, 2, 3, 4, 5 };
            d = 4;
           
            ret = LeftRotateNoPerformatic(arr, d);
            PrintArray(ret);

            Console.WriteLine("Case 3");
            arr = new int[] { 1, 2, 3, 4, 5 };
            d = 4;
            ret = LetfRotate(arr, d);
            PrintArray(ret);
        }

        private static void PrintArray(int[] ret)
        {
            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }
        }

        static int[] LeftRotateNoPerformatic(int[] arr, int d)
        {
            for (int i = 0; i < d; i++)
            {
                int j, temp = arr[0];
                for (j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[j] = temp;
            }

            return arr;
        }

        static int[] LetfRotate(int[] arr, int d)
        {            
            int[] newArr = new int[arr.Length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                int newlocation = (i + (arr.Length - d)) % arr.Length;
                newArr[newlocation] = arr[i];
            }

            return newArr;
        }


    }
}
