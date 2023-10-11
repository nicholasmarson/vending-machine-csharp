using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineCLI.Accounting
{
    internal class AccountManager
    {

        private decimal balance = 0;
        private int quarter;
        private int dime;
        private int nickel;
        private int changeInCents;
        private double depositAmount;

        public decimal Balance { get => balance; set => balance = value; }
        public double DepositAmount { get => depositAmount; set => depositAmount = value; }



        public void feedMoney()
        {

        }

        public void deductFromBalance()
        {

        }

        public void dispenseChange()
        {

        }
    }
}
