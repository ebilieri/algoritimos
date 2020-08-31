using System;

namespace AlternatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "AAAA";
            int ret = AlternatingCharacters(input);
            Console.WriteLine(ret);

            input = "BBBBB";
            ret = AlternatingCharacters(input);
            Console.WriteLine(ret);

            input = "ABABABAB";
            ret = AlternatingCharacters(input);
            Console.WriteLine(ret);

            input = "BABABA";
            ret = AlternatingCharacters(input);
            Console.WriteLine(ret);

            input = "AAABBB";
            ret = AlternatingCharacters(input);
            Console.WriteLine(ret);

            input = "AABB";
            ret = AlternatingCharacters(input);
            Console.WriteLine(ret);

            input = "ABBB";
            ret = AlternatingCharacters(input);
            Console.WriteLine(ret);

        }


        static int AlternatingCharacters(string s)
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
