﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineCLI.Products
{
    internal class Candy : Product, iBuyable
    {
        public Candy(string slotNumber, string itemName, string itemType, double itemPrice, int itemQuantity)
            : base(slotNumber, itemName, itemType, itemPrice, itemQuantity)
        {

        }
    }
}
