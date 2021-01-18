using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_BankingManagementSystem
{
    class Savings:account
    {
        public Savings() : base()
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
            this.balance = balance - amount;
            Console.WriteLine("You Account Balance has been Withdrawed. Now, Balance = " + balance);
            return true;
        }
    }
}
