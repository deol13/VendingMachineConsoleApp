using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Data;

namespace VendingMachineConsoleApp.Model
{
    public class VendingMachine : IVending
    {
        Product[] products;
        readonly int[] coins;
        int money;

        public int Money { get { return money; } }

        public VendingMachine()
        {
            coins = new int[8];
            coins[0] = 1000;
            coins[1] = 500;
            coins[2] = 100;
            coins[3] = 50;
            coins[4] = 20;
            coins[5] = 10;
            coins[6] = 5;
            coins[7] = 1;

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
            bool validMoney = false;

            foreach (int coin in coins)
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

        public Dictionary<int,int> EndTransaction()
        {
            Dictionary<int, int> change = new Dictionary<int, int>();

            foreach(int coin in coins)
            {
                if ((money / coin) > 0)
                {
                    change.Add(coin, money / coin);
                    money %= coin;
                }
            }

            return change;
        }
    }
}
