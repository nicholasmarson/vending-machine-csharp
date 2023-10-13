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
        private decimal depositAmount;

        public decimal Balance { get => balance; set => balance = value; }
        public decimal DepositAmount { get => depositAmount; set => depositAmount = value; }

        public void feedMoney()
        {
            Console.WriteLine();
            Console.WriteLine("How much money would you like to deposit?");
            Console.WriteLine();
            if (decimal.TryParse(Console.ReadLine(), out depositAmount))
            {
                balance = depositAmount + balance;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number.");
            }
            Console.WriteLine("Your current balance is now $" + balance);
        }

        public void deductFromBalance()
        {
            
        }

        public void dispenseChange()
        {
            int changeInSmallestCents = (int) (balance * 100);
            quarter = changeInSmallestCents % 25;
            dime = changeInSmallestCents % 10;
            nickel = changeInSmallestCents % 5;
            double changeInDollars = changeInSmallestCents / 100.0;

            Console.WriteLine();
            Console.WriteLine("Your change is: " + balance + " in " + quarter + "quarters, " + nickel + "nickels, and " + dime + " dimes");
            Console.WriteLine();
            balance = 0;
            Console.WriteLine();
            Console.WriteLine("Your remaining balance is: " + balance);
            Console.WriteLine();

        }


        public void applyBuyOneGetOneDollarOffDiscount()
        {
            Console.WriteLine("It's BOGODO for August! You get $1 off!");
            Console.WriteLine();
            balance += 1;
        }
    }
}
