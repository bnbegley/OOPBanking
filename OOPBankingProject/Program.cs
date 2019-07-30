using System;

namespace OOPBankingProject {
    class Program {
        static void Main(string[] args) {


            Checking check1 = new Checking();
            check1.Number = "CHECKING 1001";
            check1.Name = "College Checking";

            check1.Deposit(4000);
            check1.Pay(531, 300);
            decimal chkbal = check1.GetBalance();

            Console.WriteLine($"The total in College Checking is {chkbal}.");




            Savings sav1 = new Savings();
            sav1.Number = "SAV001";
            sav1.Name = "Savings1";


            Account acct = new Account();
            acct.Number = "1001";
            acct.Name = "Test Account";
            acct.Deposit(100);
            decimal balance = acct.GetBalance();


           bool ItWorked = acct.TransferTo(sav1, 50);
            decimal sav1bal = sav1.GetBalance();

           // Console.WriteLine(sav1.Print());
           // Console.WriteLine(acct.Print());

                Account[] accounts = new Account[] { sav1, acct, check1 };
            foreach(Account accts in accounts) {
                Console.WriteLine(accts.Print());

            }




            /*
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
            */



            //CHECK ON THIS AND REDO IT
            /*
            MoneyMarket mm = new MoneyMarket();
            mm.Number = "1003";
            mm.Name = "Money Market Account";
            mm.IntRateMM = 0.03;

            decimal mmbal = mm.GetBalance();
            decimal InterestToBePaidMM = mm.MMCalcIntRate(12);

            mm.Deposit(10000);

            Console.WriteLine("Current balance is {");
            */





















            /*
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
