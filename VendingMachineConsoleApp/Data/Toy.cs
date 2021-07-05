using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachineConsoleApp.Data
{
    public class Toy : Product
    {
        public override string Name { get { return Name; } }

        public override string HowToUse { get { return HowToUse; } }

        public override string Type { get { return Type; } }

        public override int Price { get { return Price; } }

        public Toy()
        {

        }

        public override string Examine()
        {
            throw new NotImplementedException();
        }

        public override string Use()
        {
            throw new NotImplementedException();
        }
    }
}
