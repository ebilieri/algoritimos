using System;
using System.Collections.Generic;
using System.Linq;

namespace MakeAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "cde";
            string b = "abc";

            int ret = MakeAnagram(a, b);
            Console.WriteLine(ret);

            a = "fcrxzwscanmligyxyvym";
            b = "jxwtrhvujlmrpdoqbisbwhmgpmeoke";
            ret = MakeAnagram(a, b);
            Console.WriteLine(ret);
        }


        static int MakeAnagram(string a, string b)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int length = 0;

            foreach (var c in a)
            {
                if (dict.ContainsKey(c))
                    dict[c] = dict[c] + 1;
                else
                    dict.Add(c, 1);
            }

            foreach (var c in b)
            {
                if (dict.ContainsKey(c) && dict[c] != 0)
                {
                    dict[c] = dict[c] - 1;
                    length += 2;
                }
            }

            return a.Length + b.Length - length;
        }

    }
}
