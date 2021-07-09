using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Snack : Product
    {
        //They are private and readonly because they are only suppose to be set in the constructor and not after that.
        private readonly int calories;
        private readonly int weight;
        private readonly bool peanutsOrNot;

        public int Calories { get { return calories; } }
        public bool PeanutsOrNot { get { return peanutsOrNot; } }
        public int Weight { get { return weight; } }

        public Snack(string name, string type, int price, 
                    int weight, 
                    int calories,
                    bool peanutsOrNot) : base (name, type, price)
        { 
            this.weight = CheckIntFields(weight);
            this.calories = CheckIntFields(calories);
            this.peanutsOrNot = peanutsOrNot;
        }

        public override string Examine()
        {
            string str = "---- Snack ----\n";
            str += base.ToString() + $"Weighs: {weight}grams\nCalories: {calories}\n";

            if (peanutsOrNot)
                str += "Do contain peanuts.\n";
            else
                str += "Do not contain peanuts.\n";

            return str;
        }

        public override string Use()
        {
            return "Unwrap/Open and start eating.";
        }
    }
}
