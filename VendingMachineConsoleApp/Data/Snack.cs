using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Snack : Product
    {
        private readonly string type;
        private readonly int weight;

        public string Type { get { return type; } }
        public int Weight { get { return weight; } }

        public Snack(string name, string type, int weight, int price) : base (name, price)
        {
            this.type = CheckStringFields(type);
            this.weight = CheckIntFields(weight);
        }

        public override string Examine()
        {
            return base.ToString() + $"Type of snack: {type}\nWeighs: {weight}grams\n";
            //return $"{type} named {name}, weights {weight} and is priced at {price}.";
        }

        public override string Use()
        {
            return "Unwrap/Open and start eating.";
        }
    }
}
