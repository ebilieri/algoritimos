using System;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "AAAA";
            int ret = alternatingCharacters(input);
            Console.WriteLine(ret);

            input = "BBBBB";
            ret = alternatingCharacters(input);
            Console.WriteLine(ret);

            input = "ABABABAB";
            ret = alternatingCharacters(input);
            Console.WriteLine(ret);

            input = "BABABA";
            ret = alternatingCharacters(input);
            Console.WriteLine(ret);

            input = "AAABBB";
            ret = alternatingCharacters(input);
            Console.WriteLine(ret);

            input = "AABB";
            ret = alternatingCharacters(input);
            Console.WriteLine(ret);

            input = "ABBB";
            ret = alternatingCharacters(input);
            Console.WriteLine(ret);

        }


        static int alternatingCharacters(string s)
        {
            char[] arr = s.ToCharArray();
            
            int remove = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1 && arr[i] == arr[i + 1] )
                {
                    remove++;
                }
            }

            return remove;

        }
    }
}
