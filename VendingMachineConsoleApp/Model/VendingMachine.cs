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

            products = new Product[0];
        }

        public Product Purchase(int index)
        {
            Product product = null;

            if (index > 0 && index < products.Length)
            {
                //if(products[index].Cost <= money)
                    product = products[index];
            }

            return product;
        }

        public string ShowAll()
        {
            string show = "";
            int vendingNumber = 1;

            foreach (Product product in products)
            {
                show += $"{vendingNumber++}: {product}\n"; //ToString?
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
