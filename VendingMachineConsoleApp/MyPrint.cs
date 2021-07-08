using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp
{
    public static class MyPrint
    {

        public static string PrintAndAsk(string whatToAsk)
        {
            Console.Write(whatToAsk);

            return Console.ReadLine();  //Or readkey?
        }

        public static void Print(params string[] printArr)
        {
            foreach (string str in printArr)
            {
                Console.WriteLine(str);
            }
        }

        public static void PrintError(string errorMessage)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.ResetColor();
            Console.ReadKey();
        }

        public static void PrintEmptyLines(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
            }
        }

        public static void ResetConsole()
        {
            Console.Clear();
        }
    }
}
