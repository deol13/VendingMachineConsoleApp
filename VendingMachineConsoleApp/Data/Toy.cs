using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Toy : Product
    {
        private string type;

        public string Type { get { return Name; } }
        public override string Name { get { return Name; } }
        public override int Price { get { return Price; } }

        public Toy(string name, string type, int price)
        {
            SetStringFields(name, this.name);
            SetStringFields(type, this.type);
            SetIntFields(price, this.price);
        }
        protected override void SetStringFields(string newData, string field)
        {
            if (string.IsNullOrWhiteSpace(newData))
            {
                field = newData;
            }
            else
            {
                throw new ArgumentException("Empty or only whitespace is not allowed.");
            }

        }
        protected override void SetIntFields(int newData, int field)
        {
            if (newData >= 0)
            {
                field = newData;
            }
            else
            {
                throw new ArgumentException("0 or less price is not allowed.");
            }
        }


        public override string Examine()
        {
            return $"{type} toy named {name}, priced at {price}.";
        }

        public override string Use()
        {
            return "You can play with it";
        }
    }
}
