﻿using System;
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

        public override string Name { get { return Name; } }

        public override int Price { get { return Price; } }

        public Snack(string name, string type, int weight, int price)
        {
            SetStringFields(name, this.name);
            SetStringFields(type, this.type);
            SetIntFields(weight, this.weight);
            SetIntFields(price, this.price);
        }

        protected override void SetStringFields(string newData, string field)
        {
            if(string.IsNullOrWhiteSpace(newData))
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
            if(newData >= 0)
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
            return $"{type} named {name}, weights {weight} and is priced at {price}.";
        }

        public override string Use()
        {
            return "Unwrap/Open and start eating.";
        }
    }
}
