using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public abstract class Product
    {
        protected string name;
        protected int price;

        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract string Name { get; }
        public abstract int Price { get; }


        //ToString();
        public abstract string Examine();

        public abstract string Use();

    }
}
