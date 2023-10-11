using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineCLI.Products
{
    internal interface iBuyable
    {
        string SlotNumber { get; }
        string ItemName { get; }
        string ItemType { get; }
        double ItemPrice { get; }
        int ItemQuantity { get; }

    }
}
