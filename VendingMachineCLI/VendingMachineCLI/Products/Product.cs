using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineCLI.Products
{
    internal class Product : iBuyable
    {
        private string slotNumber;
        private string itemName;
        private string itemType;
        private double itemPrice;
        private int itemQuantity = 5;

        public string SlotNumber { get => slotNumber; set => slotNumber = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public string ItemType { get => itemType; set => itemType = value; }
        public double ItemPrice { get => itemPrice; set => itemPrice = value; }
        public int ItemQuantity { get => itemQuantity; set => itemQuantity = value; }

        public Product(string slotNumber, string itemName, string itemType, double itemPrice, int itemQuantity)
        {
            this.slotNumber = slotNumber;
            this.itemName = itemName;
            this.itemType = itemType;
            this.itemPrice = itemPrice;
            this.itemQuantity = itemQuantity;
        }

        public Product()
        {

        }

        public bool isSoldOut()
        {
            return itemQuantity == 0;
        }

        public void decreaseQuantityCounter()
        {
            if (itemQuantity > 0)
            {
                itemQuantity--;
            }
        }
    }
}
