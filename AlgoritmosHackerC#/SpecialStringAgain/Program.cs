using System;
using System.Linq;

namespace SpecialStringAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "asasd";
            long ret = SubstrCount(input.Length, input); // 7
            Console.WriteLine(ret);

            input = "abcbaba";
            ret = SubstrCount(input.Length, input); // 10
            Console.WriteLine(ret);

            input = "aaaa";
            ret = SubstrCount(input.Length, input); // 10
            Console.WriteLine(ret);


            Console.WriteLine("No Performatic!");
            input = "asasd";
            ret = SubstrCountNoPerformatic(input.Length, input); // 7
            Console.WriteLine(ret);

            input = "abcbaba";
            ret = SubstrCountNoPerformatic(input.Length, input); // 10
            Console.WriteLine(ret);

            input = "aaaa";
            ret = SubstrCountNoPerformatic(input.Length, input); // 10
            Console.WriteLine(ret);
        }

        static long SubstrCount(int n, string s)
        {
            long retorno = n;

            for (int i = 0; i < s.Length; i++)
            {
                int repeat = 0;
                while (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    repeat++;
                    i++;
                }

                retorno += repeat * (repeat + 1) / 2;

                int pointer = 1;

                while (i - pointer >= 0 && i + pointer < s.Length && s[i + pointer] == s[i - 1] && s[i - pointer] == s[i - 1])
                {
                    retorno++;
                    pointer++;
                }
            }

            return retorno;
        }

        static long SubstrCountNoPerformatic(int n, string s)
        {
            long retorno = n;
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
