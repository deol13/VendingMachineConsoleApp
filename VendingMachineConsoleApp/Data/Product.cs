using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public abstract class Product
    {
        protected string name;
        protected string howToUse;
        protected int price;

        public abstract string Name { get; }
        public abstract int Price { get; }


        //ToString();
        public abstract string Examine();

        public abstract string Use();

    }
}
