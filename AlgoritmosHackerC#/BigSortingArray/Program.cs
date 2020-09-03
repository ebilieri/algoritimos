using System;
using System.Collections;

namespace BigSortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "1", "2", "100", "12303479849857341718340192371", "3084193741082937", "3084193741082938", "111", "200" };
            PrintData(arr);

            Console.WriteLine("Case 2");
            arr = new string[] { "31415926535897932384626433832795", "1", "3", "10", "3", "5" };
            PrintData(arr);

            Console.WriteLine("Hello World!");
        }

        private static void PrintData(string[] arr)
        {

            var ret = BigSorting(arr);
            foreach (var item in ret)
            {
                Console.WriteLine(item);
            }
        }

        static string[] BigSorting(string[] unsorted)
        {
            MyCompareClass myCompare = new MyCompareClass();
            Array.Sort(unsorted, myCompare);

            return unsorted;

        }
    }

    public class MyCompareClass : IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            string s1 = (string)x;
            string s2 = (string)y;

            if (s1.Length < s2.Length) return -1;
            if (s1.Length > s2.Length) return 1;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] < s2[i]) return -1;
                if (s1[i] > s2[i]) return 1;
            }

            return 0;
        }
    }
}
