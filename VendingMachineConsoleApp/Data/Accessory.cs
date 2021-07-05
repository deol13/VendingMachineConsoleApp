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

        public override string HowToUse { get { return HowToUse; } }

        public override int Price { get { return Price; } }

        public Accessory( string name, string material, int price)
        {
            this.name = name;
            this.material = material;
            this.price = price;
            howToUse = "You wear it.";
        }

        public override string Examine()
        {
            throw new NotImplementedException();
        }

        public override string Use()
        {
            throw new NotImplementedException();
        }
    }
}
