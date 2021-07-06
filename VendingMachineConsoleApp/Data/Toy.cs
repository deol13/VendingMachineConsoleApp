using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Toy : Product
    {
        private string type;

        public string Type { get { return type; } }
        public override string Name { get { return name; } }
        public override int Price { get { return price; } }

        public Toy(string name, string type, int price)
        {
            SetStringFields(name, 1);   //Case 1 is name
            SetStringFields(type, 2);   //Case 2 is type
            SetIntFields(price, this.price);
        }

        /// <summary>
        /// Case 1 is name. Case 2 is type.
        /// </summary>
        /// <param name="newData">New value</param>
        /// <param name="whichField">Which case in the switch is suppose to be accessed</param>
        public override void SetStringFields(string newData, int whichField)
        {
            if (!string.IsNullOrWhiteSpace(newData))
            {
                switch(whichField)
                {
                    case 1:
                        name = newData;
                        break;
                    case 2:
                        type = newData;
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
        /// Case is irrelevent
        /// </summary>
        /// <param name="newData">New value</param>
        /// <param name="whichField">There is no case in this</param>
        public override void SetIntFields(int newData, int whichField)
        {
            if (newData > 0)
            {
                price = newData;
            }
            else
            {
                throw new ArgumentException("0 or less price is not allowed.");
            }
        }


        public override string Examine()
        {
            return $"{type} toy named {name}, priced at {price}.";
        }

        public override string Use()
        {
            return "You can play with it";
        }
    }
}
