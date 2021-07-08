using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Toy : Product
    {
        private string material;
        private string color;
        private int sizeInCm; //In cm


        public string Material { get { return material; } }
        public string Color { get { return color; } }
        public int SizeInCm { get { return sizeInCm; } }


        public Toy(string name, string type, int price,
                   string material,
                   string color,
                   int sizeInCm) : base(name, type, price)
        {
            this.material = CheckStringFields(material);
            this.color = CheckStringFields(color);
            this.sizeInCm = CheckIntFields(sizeInCm);
        }

        public override string Examine()
        {
            string str = "---- Toy ----\n";
            str += base.ToString() + $"Material: {type}\nColor: {color}\nSize: {sizeInCm}cm\n";
            return str;
        }

        public override string Use()
        {
            return "You can play with it";
        }
    }
}
