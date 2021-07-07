using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Toy : Product
    {
        private string type;

        public string Type { get { return type; } }

        public Toy(string name, string type, int price) : base(name, price)
        {
            this.type = CheckStringFields(type);
        }

        public override string Examine()
        {
            return base.ToString() + $"Type of toy: {type}\n";
        }

        public override string Use()
        {
            return "You can play with it";
        }
    }
}
