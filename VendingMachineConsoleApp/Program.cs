using System;
using System.Collections;
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
            List<Product> listOfBoughtProducts = new List<Product>();

            const string menu = "Welcome to THE vending machine.\nTo purchase a product please input a number between 1 and 3, input 4 to insert money and 99 to exit:\n";
            int userChoice = 0;
            bool continueTheGame = true;

            while(continueTheGame)
            {
                MyPrint.ResetConsole();
                MyPrint.Print(menu);
                ShowAllProducts(vMachine);
                MyPrint.Print("Money pool: " + vMachine.Money.ToString());

                string userInput = MyPrint.PrintAndAsk("Input a valid vending number(Product 1-3, insert money 4 or exit 99): ");
                int.TryParse(userInput, out userChoice);

                if (userChoice == 99 || userChoice > 0 && userChoice < 5)
                {
                    switch(userChoice)
                    {
                        case 1:
                        case 2: 
                        case 3:
                            Product bought = vMachine.Purchase(userChoice);
                            if (bought != null)
                                listOfBoughtProducts.Add(bought);
                            else
                                MyPrint.PrintError($"Not enough money left in the vending machine.");
                            break;
                        case 4:
                            userInput = MyPrint.PrintAndAsk("Insert money, only the denominations 1,5,10,20,50,100,500,1000 works: ");
                            int.TryParse(userInput, out int moneyInserted);

                            if (!vMachine.InsertMoney(moneyInserted))
                                MyPrint.PrintError($"{userInput} is an invalid denominations. Only 1, 5, 10, 20, 50, 100, 500, 1000 works.");

                            break;
                        case 99:
                            Dictionary<int, int> changeBack = vMachine.EndTransaction();

                            MyPrint.Print($"---Change back---");
                            foreach (KeyValuePair<int, int> coin in changeBack)
                            {
                                MyPrint.Print($"{coin.Value}: {coin.Key}kr bill(s)");
                            }
                            MyPrint.PrintEmptyLines(1);

                            MyPrint.Print($"---Items bought---");
                            foreach (Product item in listOfBoughtProducts)
                            {
                                MyPrint.Print(item.Name);
                            }

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
                    MyPrint.PrintError($"{userInput} is an Invalid vending choice. Only 1 to 4 or 99 are valid");
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
