using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_BankingManagementSystem
{
    abstract class account
    {
        public readonly string name;
        public readonly string ID;
        public readonly DOB DOB;
        public readonly string nominee;
        public double balance;
        protected string type;
        public double amount;
        public abstract bool deposit(double amount);
        public abstract bool withdraw(double amount);
        public double getBalance()
        {
            return balance;
        }
        public string getAccType()
        {
            string actype;
            actype = Convert.ToString(Console.ReadLine());
            return actype;
        }
        public void printAccount()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Date of Birth :" + DOB);
            Console.WriteLine("Nominee : " + nominee);
            Console.WriteLine("Balance :" + balance);
        }
        public account()
        {

        }
        public account(string name, DOB DOB, string nominee, double balance)
        {
            this.name = name;
            this.DOB = DOB;
            this.nominee = nominee;
            this.balance = balance;
        }
    }
}
