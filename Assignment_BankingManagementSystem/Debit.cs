using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_BankingManagementSystem
{
    class Debit:account
    {
        public double maxBalance = 100000;
        private double dailyTransLimit = 20000;

        public Debit() : base()
        {

        }

        public Debit(string name, DOB DOB, string nominee, double balance) : base(name, DOB, nominee, balance)
        {

        }

        public override bool deposit(double amount)
        {
            this.amount = amount;
            if (amount > maxBalance)
            {
                Console.WriteLine("You can not Seposit more than 100000!");
                return false;
            }
            else
            {
                this.balance = balance + amount;
                Console.WriteLine("You Account Balance has been Seposited. Now, Balance = " + balance);
                return true;
            }
        }

        public override bool withdraw(double amount)
        {
            this.amount = amount;

            if (amount > dailyTransLimit)
            {
                Console.WriteLine("You can not Withdraw more than 20000.");
                return false;
            }
            else if (amount > maxBalance)
            {
                Console.WriteLine("You can not Withdraw that Amount of Money!");
                return false;
            }
            else
            {
                this.balance = balance - amount;
                Console.WriteLine("You Account Balance has been Withdrawed.Now, Balance = " + balance);
                return true;
            }
        }
    }
}