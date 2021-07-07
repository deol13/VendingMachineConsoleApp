using System;
using System.Collections.Generic;
using System.Text;
using VendingMachineConsoleApp.Data;

namespace VendingMachineConsoleApp.Model
{
    interface IVending
    {
        Product Purchase(int index);

        string ShowAll();

        bool InsertMoney(int money);

        Dictionary<int,int> EndTransaction();
    }
}
