using System;
using System.Collections.Generic;
using System.IO;
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

            InputByTextFile(dictionary, query);
        }

        private static void InputByTextFile(List<string> dictionary, List<string> query)
        {
            List<int> result;
            Console.WriteLine("Case 3");
            // ------------
            using (var sr = new StreamReader(Directory.GetCurrentDirectory() + @"\inputDictionary.txt"))
            {
                dictionary.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                    dictionary.Add(line);

            }

            using (var sr = new StreamReader(Directory.GetCurrentDirectory() + @"\inputQuery.txt"))
            {
                query.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                    query.Add(line);

            }

            result = stringAnagram(dictionary, query);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }            
        }

        public static List<int> stringAnagram(List<string> dictionary, List<string> query)
        {
            List<int> list = new List<int>();
            
            // Ordenar anagram e agrupar itens no Dictionary
            Dictionary<string, int> dictOrdered = new Dictionary<string, int>();
            for (int j = 0; j < dictionary.Count(); j++)
            {
                string str2 = string.Concat(dictionary[j].ToLower().OrderBy(x => x));

                if (dictOrdered.ContainsKey(str2))
                    dictOrdered[str2] = dictOrdered[str2] + 1;
                else
                    dictOrdered.Add(str2, 1);
            }

            // Ordernar anagrama
            string[] queryOrdered = new string[query.Count()];
            for (int i = 0; i < query.Count(); i++)
            {
                string str1 = string.Concat(query[i].ToLower().OrderBy(x => x));
                queryOrdered[i] = str1;
            }

            // Verificar anagramas na lista
            foreach (var item in queryOrdered)
            {                
                if (dictOrdered.ContainsKey(item))
                    list.Add(dictOrdered[item]);
                else
                    list.Add(0);
            }

            return list;
        }
    }
}
