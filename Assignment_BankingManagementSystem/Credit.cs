using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_BankingManagementSystem
{
    class Credit:account
    {
        public double minBalance = -100000;
        private double dailyWithdrawLimit = 20000;

        public Credit() : base()
        {

        }
        public Credit(string name, DOB DOB, string nominee, double balance) : base(name, DOB, nominee, balance)
        {

        }
    
        public override bool deposit(double amount)
        {
            this.amount = amount;
            this.balance = balance + amount;
            Console.WriteLine("You Account Balance has been Deposited. Now, Balance = " + balance);
            return true;
        }
        public override bool withdraw(double amount)
        {
            this.amount = amount;
            if (amount < this.minBalance)
            {
                Console.WriteLine("Your Account don't have sufficient Amount of Money!");
                return false;
            }
            else if (amount > dailyWithdrawLimit)
            {
                Console.WriteLine("You cannot Withdraw more than 20000.");
                return false;
            }
            else
            {
                this.balance = balance - amount;
                Console.WriteLine("You Account balance has been Withdrawed. Now, Balance = " + balance);
                return true;
            }
        }
    }
}
