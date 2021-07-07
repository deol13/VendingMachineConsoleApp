using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public abstract class Product
    {
        protected string name;
        protected int price;

        public string Name { get { return name; } }
        public int Price { get { return price; } }

        public abstract string Examine();
        public abstract string Use();

        public Product(string name, int price)
        {
            this.name = CheckStringFields(name);
            this.price = CheckIntFields(price);
        }

        /// <summary>
        /// Checks if the string is null, empty or only contains white spaces.
        /// Throws expection in that case
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
        /// Checks if the int is 0 or less. Throws expection in that case
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
            return $"Name: {name}\nPrice: {price}\n";
        }

    }
}
