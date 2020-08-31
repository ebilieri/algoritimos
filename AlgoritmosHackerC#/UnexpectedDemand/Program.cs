using System;
using System.Collections.Generic;

namespace UnexpectedDemand
{
    /// <summary>
    ///Unexpected Demand
    ///A widget manufacturer is facing unexpectedly high demand for its new product,. 
    ///They would like to satisfy as many customers as possible.Given a number 
    ///of widgets available and a list of customer orders, what is the maximum number 
    ///of orders the manufacturer can fulfill in full?
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            List<int> ped = new List<int> { 10, 30, 40, 50 };
            int itms = 40;

            int result = FilledOrders(ped, itms);
            Console.WriteLine(result);


            Console.WriteLine("Case 2");

            ped = new List<int> { 3, 5, 4, 6, 1, 2 };
            itms = 9;

            result = FilledOrders(ped, itms);
            Console.WriteLine(result);
        }


        public static int FilledOrders(List<int> order, int k)
        {
            order.Sort();
            int count = 0;
            int pedido = 0;
            foreach (var item in order)
            {

                pedido += item;
                if (pedido <= k)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
