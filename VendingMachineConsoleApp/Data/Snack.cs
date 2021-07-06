using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Snack : Product
    {
        private string type;
        private int weight;

        public string Type { get { return type; } }
        public int Weight { get { return weight; } }

        public override string Name { get { return name; } }
        public override int Price { get { return price; } }
        public Snack(string name, string type, int weight, int price)
        {
            SetStringFields(name, 1);   //Case 1 is name
            SetStringFields(type, 2);   //Case 2 is type
            SetIntFields(price, 1);    //Case 1 is price
            SetIntFields(weight, 2);  //Case 2 is weight
        }

        /// <summary>
        /// Case 1 is name. Case 2 is type.
        /// </summary>
        /// <param name="newData">New value</param>
        /// <param name="whichField">Which case in the switch is suppose to be accessed</param>
        public override void SetStringFields(string newData, int whichField)
        {
            if(!string.IsNullOrWhiteSpace(newData))
            {
                switch (whichField)
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
        /// Case 1 is price. Case 2 is wWeight.
        /// </summary>
        /// <param name="newData">New value</param>
        /// <param name="whichField">Which case in the switch is suppose to be accessed</param>
        public override void SetIntFields(int newData, int whichField)
        {
            if(newData > 0)
            {
                switch (whichField)
                {
                    case 1:
                        price = newData;
                        break;
                    case 2:
                        weight = newData;
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
            return $"{type} named {name}, weights {weight} and is priced at {price}.";
        }

        public override string Use()
        {
            return "Unwrap/Open and start eating.";
        }
    }
}
