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

        public override string HowToUse { get { return HowToUse; } }

        public override int Price { get { return Price; } }

        public Toy(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
            howToUse = "You can play with it";
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
