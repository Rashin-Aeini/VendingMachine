using System;
using System.Collections.Generic;
using VendingMachine.Models;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            IVending vending = new Machine();
            for (int index = 0; index < 84; index++)
            {
                vending.InsertMoney(20);
            }
            foreach(KeyValuePair<int, int> value in vending.EndTransaction())
            {
                Console.WriteLine("{0} ==> {1}", value.Key, value.Value);
            }
            Console.ReadKey();
        }
    }
}
