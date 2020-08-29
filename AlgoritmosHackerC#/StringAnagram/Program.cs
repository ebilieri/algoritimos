using System;
using System.Collections.Generic;
using System.Linq;

namespace StringAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var dictionary = new List<string> { "heater", "cold", "clod", "reheat", "docl" };

            var query = new List<string> { "codl", "heater", "abcd" };

            var result = stringAnagram(dictionary, query);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Case 2");
            // ------------
            dictionary = new List<string> { "listen", "tow", "silent", "lisent", "two", "abc", "no", "on" };
            query = new List<string> { "two", "bca", "no", "listen" };

            result = stringAnagram(dictionary, query);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }


        /*
     * Complete the 'stringAnagram' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY dictionary
     *  2. STRING_ARRAY query
     */

        //public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        //{
        //    List<int> list = new List<int>();
        //    string[] q = new string[query.Count()];
        //    string[] d = new string[dictionary.Count()];

        //    for (int i = 0; i < query.Count(); i++)
        //    {
        //        string str1 = string.Concat(query[i].ToLower().OrderBy(x => x));
        //        q[i] = str1;
        //    }

        //    for (int j = 0; j < dictionary.Count(); j++)
        //    {
        //        string str2 = string.Concat(dictionary[j].ToLower().OrderBy(x => x));
        //        d[j] = str2;
        //    }

        //    foreach (var item in q)
        //    {                
        //        list.Add(d.Where(x => x == item).Count());
        //    }
        //    return list;
        //}


        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            List<int> list = new List<int>();
            string[] q = new string[query.Count()];
            string[] d = new string[dictionary.Count()];

            for (int i = 0; i < query.Count(); i++)
            {
                string str1 = string.Concat(query[i].ToLower().OrderBy(x => x));
                q[i] = str1;
            }

            for (int j = 0; j < dictionary.Count(); j++)
            {
                string str2 = string.Concat(dictionary[j].ToLower().OrderBy(x => x));
                d[j] = str2;
            }

            foreach (var item in q)
            {
                list.Add(d.Where(x => x == item).Count());
            }
            return list;
        }
    }
}
