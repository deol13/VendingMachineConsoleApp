using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public abstract class Product
    {
        protected string name;
        protected int price;

        public abstract void SetStringFields(string newData, int whichField);
        public abstract void SetIntFields(int newData, int whichField);

        public abstract string Name { get; }
        public abstract int Price { get; }


        public abstract string Examine();

        public abstract string Use();

    }
}
