using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualizingArrayElements
{
    /// <summary>
    /// 1. Equalizing Array Elements
    ///Given an array of integers, transform it so that at least a certain number of elements in the array are equal.
    ///To achieve this, you can perform an operation where you select an element in the array 
    ///and divide it by the given division parameter using integer division.What is the minimum number 
    ///of operations that must be performed to achieve this goal on a certain array?
    ///
    ///For example, let's say arr = [1, 2, 3, 4, 5]. 
    ///The desired number of equal elements is denoted as threshold = 3, and the division parameter is d = 2. 
    ///If you divide the value 4 once and the value 5 once using integer division, you get the array [1, 2, 3, 2, 2], which contains 3 equal elements. 
    ///There is no way to achieve this in less than 2 operations. Therefore, the answer is 2.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new List<int> { 64, 30, 25, 33 };
            // limite
            int threshold = 2;
            // parameter divisao
            int d = 2;

            int r1 = MinOperations(arr, threshold, d);
            Console.WriteLine(r1);

            Console.WriteLine("Cadse 2");
            //-------------
            arr = new List<int> { 1, 2, 3, 4 };
            // limite
            threshold = 4;
            // parameter divisao
            d = 3;

            int r2 = MinOperations(arr, threshold, d);
            Console.WriteLine(r2);
        }


        public static int MinOperations(List<int> arr, int threshold, int d)
        {
            int totalOperacoes = 0;
            int? contagem = 0;

            var dict = new List<Contegem>();

            while (totalOperacoes < threshold)
            {
                // Incrementar total de operações primeiro
                totalOperacoes++;

                for (int i = 0; i < arr.Count(); i++)
                {
                    // Checkar se valor e maior que zero
                    if (arr[i] > 0)
                    {
                        int result = arr[i] / d;
                        arr[i] = result;

                        dict.Add(new Contegem
                        {
                            Result = result,
                            CountOperation = totalOperacoes
                        });

                        contagem = dict.GroupBy(item => item.Result)
                                    .Where(item => item.Count() > 1)
                                    .FirstOrDefault()?.Sum(item => item.CountOperation);
                    }
                }

            }

            return Convert.ToInt32(contagem);
        }
    }

    public class Contegem
    {
        public int Result { get; set; }
        public int CountOperation { get; set; }
    }
}
