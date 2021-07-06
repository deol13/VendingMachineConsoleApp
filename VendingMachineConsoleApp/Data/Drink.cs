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

        public override string Name { get { return name; } }
        public override int Price { get { return price; } }

        public Drink( string name, string flavor, string company, int containsInCL, int price)
        {
            SetStringFields(name, 1);   //Case 1 is name
            SetStringFields(flavor, 2); //Case 2 is flavor
            SetStringFields(company, 3);//Case 3 is company
            SetIntFields(price, 1);         //Case 1 is price
            SetIntFields(containsInCL, 2);  //Case 2 is containsInCL
        }

        /// <summary>
        /// Case 1 is name. Case 2 is flavor. Case 3 is company
        /// </summary>
        /// <param name="newData">New value</param>
        /// <param name="whichField">Which case in the switch is suppose to be accessed</param>
        public override void SetStringFields(string newData, int whichField)
        {
            if (!string.IsNullOrWhiteSpace(newData))
            {
                switch (whichField)
                {
                    case 1:
                        name = newData;
                        break;
                    case 2:
                        flavor = newData;
                        break;
                    case 3:
                        company = newData;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                throw new ArgumentException("Empty or only whitespace is not allowed.");
            }

        }
        /// <summary>
        /// Case 1 is price. Case 2 is containsInCL.
        /// </summary>
        /// <param name="newData">New value</param>
        /// <param name="whichField">Which case in the switch is suppose to be accessed</param>
        public override void SetIntFields(int newData, int whichField)
        {
            if (newData > 0)
            {
                switch (whichField)
                {
                    case 1:
                        price = newData;
                        break;
                    case 2:
                        containsInCL = newData;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                throw new ArgumentException("0 or less price is not allowed.");
            }
        }


        public override string Examine()
        {
            return $"{flavor} flavored {name} made by {company}, contains {containsInCL}cl and is priced at {price}.";
        }

        public override string Use()
        {
            return "Open it up and drink.";
        }
    }
}
