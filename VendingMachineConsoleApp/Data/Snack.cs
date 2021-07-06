using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Snack : Product
    {
        private string flavor;
        private string type;

        public string Flavor { get { return flavor; } }

        public string Type { get { return type; } }

        public override string Name { get { return Name; } }

        public override int Price { get { return Price; } }

        public Snack(string name, string flavor, string type, int price) : base(name, price)
        {
            this.flavor = flavor;
            this.type = type;
        }


        public override string Examine()
        {
            return $"{name} snack with {flavor} flavor, priced at {price}.";
        }

        public override string Use()
        {
            return "Unwrap/Open and start eating.";
        }
    }
}
