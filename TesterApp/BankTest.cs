
using Banking;
using System;

namespace Banking
{
    class BankTest
    {
        static void Main(string []args)
        {
            Account acct1 = new Account(56000);  //acct Object is created

            Console.WriteLine("1.withdraw");
            Console.WriteLine("2.deposit");

            int option = int.Parse(Console.ReadLine());   //Readline i/p is in string format Converted it into int by int.Parse

            Console.WriteLine("Please Enter Amount :");
            float amount = float.Parse(Console.ReadLine()); //string to float.Parse

            switch (option)
            {
                case 1:
                    {
                        acct1.Withdraw(amount);
                    }
                    break;
                case 2:
                    {
                        acct1.Deposit(amount);
                    }
                    break;

            }

            float balance = acct1.Balance; // remaining Balance is return to balance variable
            Console.WriteLine("Your remaining Balance= {0}", balance); //remaining balance is printed

            Console.WriteLine(acct1);  
           Console.ReadLine();
        }
    }
}
