using System;
using System.Collections.Generic;

namespace VendingMachineConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> coins; coins = new Dictionary<int, int>();
            coins.Add(1, 1);
            coins.Add(5, 5);
            coins.Add(10, 10);
            coins.Add(20, 20);
            coins.Add(50, 50);
            coins.Add(100, 100);
            coins.Add(500, 500);
            coins.Add(1000, 1000);

            Console.WriteLine(1000 % coins[1000]);
        }

        static string Print(string whatToAsk)
        {
            Console.Write(whatToAsk);

            return Console.ReadLine();  //Or readkey?
        }


    }
}
