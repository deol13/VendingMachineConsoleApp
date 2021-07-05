using System;

namespace VendingMachineConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static string Print(string whatToAsk)
        {
            Console.Write(whatToAsk);

            return Console.ReadLine();  //Or readkey?
        }


    }
}
