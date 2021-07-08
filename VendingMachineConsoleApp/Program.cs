using System;
using System.Collections.Generic;
using VendingMachineConsoleApp.Data;
using VendingMachineConsoleApp.Model;

namespace VendingMachineConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vMachine = new VendingMachine();

            while(true)
            {
                string[] menuStrArr = vMachine.ShowAll();

                Console.WriteLine();
            }
        }

        static string PrintAndAsk(string whatToAsk)
        {
            Console.Write(whatToAsk);

            return Console.ReadLine();  //Or readkey?
        }

        static string PrintArray(string[] printArr)
        {
            foreach (string str in printArr)
            {

            }
        }

    }
}
