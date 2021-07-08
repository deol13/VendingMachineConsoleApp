using System;
using System.Collections.Generic;
using VendingMachineConsoleApp.Data;
using VendingMachineConsoleApp.Model;

namespace VendingMachineConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vMachine = new VendingMachine();
            const string menu = "Welcome to THE vending machine.\nTo purchase a product please input a number between 1 and 3, input 4 to insert money and 99 to exit:\n";
            int userChoice = 0;
            bool continueTheGame = true;

            while(continueTheGame)
            {
                MyPrint.ResetConsole();
                MyPrint.Print(menu);
                ShowAllProducts(vMachine);
                MyPrint.Print("Money pool: " + vMachine.Money.ToString());

                string userInput = MyPrint.PrintAndAsk("Input a valid vending number: ");
                int.TryParse(userInput, out userChoice);

                if (userChoice == 99 || userChoice > 0 && userChoice < 5)
                {
                    switch(userChoice)
                    {
                        case 1:
                            //Product 1
                            MyPrint.PrintAndAsk("Product 1");
                            break;
                        case 2:
                            //Product 2
                            MyPrint.PrintAndAsk("Product 2");
                            break;
                        case 3:
                            //Product 3
                            MyPrint.PrintAndAsk("Product 3");
                            break;
                        case 4:
                            //Insert money
                            MyPrint.PrintAndAsk("Insert money");
                            break;
                        case 99:
                            //Get change back and exit
                            MyPrint.PrintEmptyLines(1);
                            MyPrint.Print("Exit");
                            continueTheGame = false;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    MyPrint.ResetConsole();
                    MyPrint.PrintError($"{userChoice} is an Invalid vending choice. Only 1 to 4 or 99 are valid");
                }
            }
            MyPrint.PrintAndAsk("Press a key to end.");
        }

        public static void ShowAllProducts(VendingMachine vMachine)
        {
            string[] showAllArray = vMachine.ShowAll();
            MyPrint.Print(showAllArray);
        }
    }
}
