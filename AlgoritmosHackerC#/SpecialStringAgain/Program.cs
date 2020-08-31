using System;
using System.Linq;

namespace SpecialStringAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "asasd";
            long ret = substrCount(input.Length, input); // 7
            Console.WriteLine(ret);

            input = "abcbaba";
            ret = substrCount(input.Length, input); // 10
            Console.WriteLine(ret);

            input = "aaaa";
            ret = substrCount(input.Length, input); // 10
            Console.WriteLine(ret);

            Console.WriteLine("Hello World!");
        }

        static long substrCount(int n, string s)
        {
            int retorno = n;
            string special;

            for (int i = 0; i < s.Length; i++)
            {
                special = string.Concat(s[i]);
                int j = i + 1;
                while (j < n)
                {
                    special += string.Concat(s[j]);

                    string anagr = string.Empty;

                    for (int x = special.Length-1; x >= 0; x--)
                    {
                        anagr += string.Concat( special[x]);
                    }

                    string middleChar = string.Empty;
                    int middle = special.Length/2 ;
                    if (middle % 2 == 0 && special.Length %2 !=0)
                        middleChar = string.Concat(special[middle]);

                    if (special == anagr && string.Concat( special[middle]) != middleChar)
                        retorno++;

                    j++;
                }
            }


            return retorno;
        }
    }
}
