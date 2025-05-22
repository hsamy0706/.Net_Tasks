using System;
using Tasks.Task1;
using Tasks.Task2;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            #region Assignment 1

            //BankAccount account1 = new() { AccountNumber = "Q12345" };

            //account1.AccountHolderName = "Hoda";
            //account1.Deposite(1000);
            //account1.Withdraw(100);
            //Console.WriteLine(account1.Balance); 
            #endregion

            #region Assignment 2
            //Product pin = new();
            //pin.Price = 10;
            //pin.UpdateStock(10);
            //Console.WriteLine(pin.StockQuantity);
            //pin.UpdateStock(-5);
            //Console.WriteLine(pin.StockQuantity); 
            #endregion

            #region Assignment 3
            //Car car = new();
            //car.Make = "kia";
            //car.Year = 2015;
            //car.Drive(1000);
            //Console.WriteLine(car.Age); 
            #endregion

            #endregion
            #region Task2
            SimplePrinter myPrinter = new();
            myPrinter.Print("Invoice.pdf");

            SmartDevice device1 = new();
            device1.Print("My Doc");
            device1.Fax("My Doc", "012435634");
            device1.Scan("My Doc");

            IMaintenance maintenance = new ServiceMachine();
            maintenance.PowerOn();
            maintenance.SelfCheck();

            IPrinter printer = new SecurePrinter();
            printer.Print("secure doc");

            // This line below would NOT work:
            //SecurePrinter sp = new SecurePrinter();
            //sp.Print("..."); // Error! Not accessible this way

            Copier copier = new("my Copier");
            copier.ShowModelInfo();
            copier.Start();

            SmartCopier smartCopier = new("my smart copier");
            IFax fax = new SmartCopier("smart fax copier");
            fax.Fax("My Smart Doc", "012435634");
            smartCopier.PowerOn();
            smartCopier.SelfCheck();
            #endregion
        }
    }
}
