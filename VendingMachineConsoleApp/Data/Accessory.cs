using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Accessory : Product
    {
        private string material;

        public string Material { get { return Material; } }
        public override string Name { get { return Name; } }

        public override int Price { get { return Price; } }

        public Accessory( string name, string material, int price)
        {
            this.name = name;
            this.material = material;
            this.price = price;
        }

        public override string Examine()
        {
            return $"{name} accessory made with {material}, priced at {price}.";
        }

        public override string Use()
        {
            return "You wear it.";
        }
    }
}
