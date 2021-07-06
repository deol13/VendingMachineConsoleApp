using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class CandyBar : Product
    {
        private string flavor;

        public string Flavor { get { return flavor; } }

        public override string Name { get { return Name; } }

        public override int Price { get { return Price; } }

        public CandyBar(string name, string flavor, int price)
        {
            this.name = name;
            this.price = price;
            this.flavor = flavor;  
        }


        public override string Examine()
        {
            return $"{name} candybar with {flavor} flavor, priced at {price}.";
        }

        public override string Use()
        {
            return "Unwrap it's wrapper and eat it.";
        }
    }
}
