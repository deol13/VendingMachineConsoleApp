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
            this.name = name;
            this.type = type;
            this.price = price;
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
