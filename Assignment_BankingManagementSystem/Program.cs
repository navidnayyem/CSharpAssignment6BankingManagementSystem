using System;

namespace Assignment_BankingManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Background Color of Console*/
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();

            /*Color of Text*/
            Console.ForegroundColor = ConsoleColor.Black;

            String input;
            DOB dob = new DOB();
            IDGENARATOR id = new IDGENARATOR();
            Credit cr = new Credit();
            Debit db = new Debit();
            Savings sv = new Savings();
            bank bn = new bank();
            Console.WriteLine("***Banking Management System***");
            while (true)
            {
                Console.WriteLine("\nNow, what you want to do?\n");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Show Account Info");
                Console.WriteLine("3. Deposit Money From Account");
                Console.WriteLine("4. Withdraw Money From Account");
                Console.WriteLine("5. Show All Accounts including ID");
                Console.WriteLine("6. Clear Screen");
                Console.WriteLine("7. Exit Program");
                Console.Write("\nEnter your Choice: ");
                object ob1 = Console.ReadLine();
                input = Convert.ToString(ob1);
                Console.WriteLine("");
                if (input == "1")
                {
                    Console.WriteLine("Enter Account Type: ");
                    bn.create_account();
                }
                else if (input == "2")
                {
                    Console.Write("Enter Account ID: ");
                    bn.showInfo();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Enter Account ID: ");
                    bn.deposit();
                }
                else if (input == "4")
                {
                    Console.WriteLine("Enter Account ID: ");
                    bn.withdraw();
                }
                else if (input == "5")
                {
                    bn.showAll();
                }
                else if (input == "6")
                {
                    Console.Clear();
                }
                else if (input == "7")
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();
            }
        }
    }
}