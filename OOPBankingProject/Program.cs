using System;

namespace OOPBankingProject {
    class Program {
        static void Main(string[] args) {

            Savings sav = new Savings();
            sav.Number = "1002";
            sav.Name = "Savings Test";
            sav.IntRate = 0.05;


            sav.Deposit(200);
            sav.Withdraw(100);
            decimal IntToBePaid = sav.CalcInterest(6);
            sav.PayInterest(IntToBePaid);
            decimal savbal = sav.GetBalance();
            Console.WriteLine($"Current Savings balance is {savbal}.");

            sav.Withdraw(300);
            savbal = sav.GetBalance();
            Console.WriteLine($"Current balance is {savbal}.");

  
            sav.Deposit(-25);
            savbal = sav.GetBalance();
            Console.WriteLine($"Current balance is {savbal}.");

            sav.Withdraw(-20);
            savbal = sav.GetBalance();
            Console.WriteLine($"Current balance is {savbal}.");







            /*
            Account acct = new Account();
            acct.Number = "1001";
            acct.Name = "Test Account";
            acct.Deposit(100);
            decimal balance = acct.GetBalance();
            Console.WriteLine($"Current balance is: {balance}. (Should be 100).");

            acct.Withdraw(10);
            balance = acct.GetBalance();
            Console.WriteLine($"Current balance is: {balance}. (Should be 90).");

            acct.Deposit(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Current balance is: {balance}. (Should be 90).");

            acct.Withdraw(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Current balance is: {balance}. (Should be 90).");

            acct.Withdraw(300);
            balance = acct.GetBalance();
            Console.WriteLine($"Current balance is: {balance}. (Should be 90.)");
            */

        }
    }
}
