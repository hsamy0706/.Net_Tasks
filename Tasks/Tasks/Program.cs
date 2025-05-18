using System;
using Tasks.Task1;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Car car = new();
            car.Make = "kia";
            car.Year = 2015;
            car.Drive(1000);
            Console.WriteLine(car.Age); 
            #endregion


        }
    }
}
