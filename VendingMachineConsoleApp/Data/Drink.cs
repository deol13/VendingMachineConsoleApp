using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Drink : Product
    {
        private readonly string flavor;
        private readonly string company;
        private readonly int containsInCL;

        public string Flavor { get { return flavor; } }
        public string Company { get { return company; } }
        public int ContainsInCL { get { return containsInCL; } }

        public Drink( 
            string name, 
            string flavor, 
            string company, 
            int containsInCL, 
            int price) : base (name, price)
        {
            this.flavor = CheckStringFields(flavor);
            this.company = CheckStringFields(company);
            this.containsInCL = CheckIntFields(containsInCL);
        } 

        public override string Examine()
        {
            return base.ToString() + $"Flavor: {flavor}\nMade by: {company}\nVolume: {containsInCL}cl\n";
        }

        public override string Use()
        {
            return "Open it up and drink.";
        }
    }
}
