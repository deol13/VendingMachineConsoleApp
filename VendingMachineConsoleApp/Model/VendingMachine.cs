using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Data;

namespace VendingMachineConsoleApp.Model
{
    public class VendingMachine : IVending
    {
        Product[] products;
        readonly Dictionary<int, int> coins;
        int money;

        public int Money { get { return money; } }

        public VendingMachine()
        {
            coins = new Dictionary<int, int>();
 
            coins.Add(1000, 1000);
            coins.Add(500, 500);
            coins.Add(100, 100);
            coins.Add(50, 50);
            coins.Add(20, 20);
            coins.Add(10, 10);
            coins.Add(5, 5);
            coins.Add(1, 1);

            money = 0;

            products = new Product[3];
            Toy toy = new Toy("Winnie the Pooh", "Stuffed Bear", 150);
            Drink drink = new Drink("Fanta", "Exotic", "Coca-Cola", 33, 20);
            Snack snack = new Snack("Marsbar", "Candy bar", 60, 15);
            products[0] = toy;
            products[1] = drink;
            products[2] = snack;
        }

        /// <summary>
        /// 1 is Toy. 2 is Drink and 3 is Snack.
        /// </summary>
        /// <param name="vendingNumber">What you want to buy</param>
        /// <returns></returns>
        public Product Purchase(int vendingNumber)
        {
            Product product = null;
            int index = vendingNumber - 1;

            if (index >= 0 && index < products.Length)
            {
                if (products[index].Price <= money)
                {
                    product = products[index];
                    money -= products[index].Price;
                }
                else
                {
                    throw new ArithmeticException("Not enough money.");
                }
            }
            else
            {
                throw new ArithmeticException("Not a valid vending number.");
            }

            return product;
        }

        public string ShowAll()
        {
            string show = "Products:\n";
            int vendingNumber = 1;

            foreach (Product product in products)
            {
                //GetType gets me the entire namespace and we only want the class name
                //so .Name on GetType() will get us only the class name.
                show += $"{vendingNumber++}: {product.GetType().Name}\n"; //ToString?
            }

            return show;
        }

        public bool InsertMoney(int insertedMoney)
        {
            Dictionary<int, int>.ValueCollection valueCoin = coins.Values;
            bool validMoney = false;

            foreach (int coin in valueCoin)
            {
                if(coin.Equals(insertedMoney))
                {
                    money += insertedMoney;
                    validMoney = true;
                    break;
                }
            }

            return validMoney;
        }

        public string EndTransaction()
        {
            string change = $"Change {money} back:";

            Dictionary<int, int>.ValueCollection valueCoin = coins.Values;

            foreach (int coin in valueCoin)
            {
                if ((money / coin) > 0)
                {
                    change += $"{money / coin}st {coin}kr\n";
                    money %= coin;
                }
            }

            return change;
        }
    }
}
