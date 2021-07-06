using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Drink : Product
    {
        private string flavor;
        private string company;
        private int containsInCL;

        public string Flavor { get { return flavor; } }
        public string Company { get { return company; } }
        public int ContainsInCL { get { return containsInCL; } }
        public override string Name { get { return Name; } }

        public override int Price { get { return Price; } }

        public Drink( string name, string flavor, string company, int containsInCL, int price)
        {
            SetStringFields(name, this.name);
            SetStringFields(flavor, this.flavor);
            SetStringFields(company, this.company);
            SetIntFields(containsInCL, this.containsInCL);
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
            return $"{flavor} flavored {name} made by {Company}, contains {containsInCL}cl and is priced at {price}.";
        }

        public override string Use()
        {
            return "Open it up and drink.";
        }
    }
}
