using System;
using System.Collections.Generic;
using Tasks.ADOTask.BL.Entities;
using Tasks.ADOTask.BL.EntityManager;
using Tasks.Task1;
using Tasks.Task2;
using Tasks.Task3;
using Tasks.Task4;

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
            //SimplePrinter myPrinter = new();
            //myPrinter.Print("Invoice.pdf");

            //SmartDevice device1 = new();
            //device1.Print("My Doc");
            //device1.Fax("My Doc", "012435634");
            //device1.Scan("My Doc");

            //IMaintenance maintenance = new ServiceMachine();
            //maintenance.PowerOn();
            //maintenance.SelfCheck();

            //IPrinter printer = new SecurePrinter();
            //printer.Print("secure doc");

            //// This line below would NOT work:
            ////SecurePrinter sp = new SecurePrinter();
            ////sp.Print("..."); // Error! Not accessible this way

            //Copier copier = new("my Copier");
            //copier.ShowModelInfo();
            //copier.Start();

            //SmartCopier smartCopier = new("my smart copier");
            //IFax fax = new SmartCopier("smart fax copier");
            //fax.Fax("My Smart Doc", "012435634");
            //smartCopier.PowerOn();
            //smartCopier.SelfCheck();
            #endregion

            #region Task3
            //int [] arr = new int[] {3,4,2,5,1 };
            //ArrayUtils arrayUtils = new();
            //arrayUtils.ReverseArray<int>(arr);
            //foreach(int item in arr)
            //{
            //    Console.Write($"{item} ");
            //}

            //Console.WriteLine();
            //try
            //{
            //    Console.WriteLine($"Maximum : {arrayUtils.FindMax(arr)}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Cash<string, int> cache = new Cash<string, int>(3);

            //cache.Add("a", 1);
            //cache.Add("b", 2);
            //cache.Add("c", 3);

            //cache.GetByKey("a");


            //cache.Add("d", 4);  // Cache exceeds max size, evicts least recently used ("b")

            ////if we try to remove b will return false as it's not exist
            //Console.WriteLine( cache.Remove("b"));
            #endregion

            #region Task4
            //MyStringCollection myStringCollection = new MyStringCollection();
            //myStringCollection.Add("Ahmad");
            //myStringCollection.Add("Mohamd");
            //myStringCollection.Add("omar");
            //myStringCollection.Add("sohaila");

            //Console.WriteLine(myStringCollection.Contains("hoda"));

            //myStringCollection.Remove("omar");

            //myStringCollection.PrintAll();

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            //EvenNumberCollection myNumbers = new(numbers);

            //IEnumerable<int> iNumbers = new EvenNumberCollection(numbers);
            //Console.WriteLine("Even numbers using yield");
            //foreach (int num in myNumbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Even numbers using custom IEnumrator");
            //foreach (int num in iNumbers)
            //{
            //    Console.Write($"{num} ");
            //}


            #endregion

            #region Task5

            #region Q1
            //List<int> numbers = new() { 3, 9, 2, 7, 10, 15 };

            //List<int> filteredNumbers = numbers.FindAll((num) => num > 5);
            //Console.WriteLine("Numbers greater than 5: ");
            //foreach (int num in filteredNumbers)
            //{
            //    Console.Write($"{num} ");
            //}
            //Console.WriteLine();
            #endregion

            #region Q2
            //List<string> names = new () { "Mona", "Ziad", "Ali", "Laila" };
            //names.Sort((n1,n2)=> n1.Length.CompareTo(n2.Length));

            //Console.WriteLine("Names sorted with length: ");
            //foreach (string name in names)
            //{
            //    Console.Write($"{name} ");
            //}
            //Console.WriteLine();

            #endregion

            #region Q3

            //Func<int, int, int> Add = (num1, num2) => num1 + num2;
            //Console.WriteLine($"Result of adding 10 , 20 : ");
            //Console.WriteLine(Add(10, 20));
            #endregion

            #region Q4

            //    Action<string> print = (name) => Console.WriteLine($"Hello, {name}!");
            //    print("Hoda");

            #endregion

            #endregion

            #region Task6
            //List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //try
            //{
            //    var page1 = myList.Paginate(1, 5);
            //    foreach (int item in page1)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}

            //var person = new { ID = 1, Name = "Hoda", age = "22" };

            //Console.WriteLine( person.ToJson());


            #endregion

            #region ADO task

            Employee emp1 = new() { Name = "Hoda", Age = 24, Department = "IT" };
            Employee emp2 = new() { Name = "Mohamed", Age = 34, Department = "HR" };

            EmployeeManager.InsertEmployee(emp1);
            EmployeeManager.InsertEmployee(emp2);

            List<Employee> employees = EmployeeManager.GetAllEmployees();

            foreach(var emp in employees)
            {
                Console.WriteLine($"ID:{emp.ID}, Name: {emp.Name}, Age:{emp.Age}, Dept: {emp.Department}");
            }


            #endregion

        }
    }
}
