using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public abstract class Product
    {
        //They are protected so they can be inherited but not modified by anthing outside the hierarchy.
        protected string name;
        protected string type;
        protected int price;

        public string Name { get { return name; } }
        public string Type { get { return type; } }
        public int Price { get { return price; } }

        public abstract string Examine();
        public abstract string Use();

        public Product(string name, string type, int price)
        {
            this.name = CheckStringFields(name);
            this.type = CheckStringFields(type);
            this.price = CheckIntFields(price);
        }

        /// <summary>
        /// Checks if the string is null, empty or only contains white spaces.
        /// Throws expection in that case.
        /// They are implemented in the base class because all the derived classes needs to check the data before modifing their fields.
        /// </summary>
        /// <param name="str">String that we want to check</param>
        /// <returns></returns>
        public string CheckStringFields(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                throw new ArgumentException("Empty or only whitespace is not allowed.");

            return str;
        }

        /// <summary>
        /// Checks if the int is 0 or less. Throws expection in that case.
        /// They are implemented in the base class because all the derived classes needs to check the data before modifing their fields.
        /// </summary>
        /// <param name="newData">The int we want to check</param>
        /// <returns></returns>
        public int CheckIntFields(int newData)
        {
            if (newData <= 0)
                throw new ArgumentException("0 or less price is not allowed.");
            return newData;
        }

        public override string ToString()
        {
            return $"Name: {name}\nType: {type}\nPrice: {price}kr\n";
        }

    }
}
