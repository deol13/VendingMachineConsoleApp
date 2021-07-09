using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Drink : Product
    {
        //They are private and readonly because they are only suppose to be set in the constructor and not after that.
        private readonly string flavor;
        private readonly string company;
        private readonly int volumeInCL;

        public string Flavor { get { return flavor; } }
        public string Company { get { return company; } }
        public int VolumeInCL { get { return volumeInCL; } }

        public Drink( string name, string type, int price,
            string flavor, 
            string company, 
            int volumeInCL ) : base (name, type, price)
        {
            this.flavor = CheckStringFields(flavor);
            this.company = CheckStringFields(company);
            this.volumeInCL = CheckIntFields(volumeInCL);
        } 

        public override string Examine()
        {
            string str = "---- Drink ----\n";
            str += base.ToString() + $"Flavor: {flavor}\nMade by: {company}\nVolume: {volumeInCL}cl\n";
            return str;
        }

        public override string Use()
        {
            return "Open it up and drink.";
        }
    }
}
