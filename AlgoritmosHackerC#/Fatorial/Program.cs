using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int ret = Fatorial(1);
            Console.WriteLine("Fatorial de 1! " + ret);

            ret = Fatorial(2);
            Console.WriteLine("Fatorial de 2! " + ret);

            ret = Fatorial(3);
            Console.WriteLine("Fatorial de 3! " + ret);

            ret = Fatorial(4);
            Console.WriteLine("Fatorial de 4! " + ret);

            ret = Fatorial(5);
            Console.WriteLine("Fatorial de 5! " + ret);

            ret = Fatorial(6);
            Console.WriteLine("Fatorial de 6! " + ret);

            ret = Fatorial(7);
            Console.WriteLine("Fatorial de 7! " + ret);

            ret = Fatorial(8);
            Console.WriteLine("Fatorial de 8! " + ret);

            ret = Fatorial(9);
            Console.WriteLine("Fatorial de 9! " + ret);

            ret = Fatorial(10);
            Console.WriteLine("Fatorial de 10! " + ret);
        }


        static int Fatorial(int number)
        {
            int resultado = 1;
            for (int fatorial = number; fatorial > 0; fatorial--)
            {
                resultado = resultado * fatorial;
                if (fatorial > 1)
                    Console.Write(fatorial + "X");
                else
                    Console.Write(fatorial);
            }

            Console.Write(" ");

            return resultado;
        }
    }
}
