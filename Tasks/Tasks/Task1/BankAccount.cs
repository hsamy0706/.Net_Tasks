using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks.Task1
{
    internal class BankAccount
    {
        public string AccountNumber { get; init; }
        public string AccountHolderName { get; set; }
        private double balance = 0;
        public double Balance {
            get { return balance; }
            private set {
                if (value < 0)
                    throw new Exception($"You can't withdraw this amount {value} as your balance is {balance}");
                else
                    balance = value;
            } 
        }

        public bool Deposite(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("you cannot add minus value");
                return false;
            }
            Balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            bool isValid = false;
            try {
                if(amount > 0)
                {
                    Balance -= amount;
                    isValid = true;
                }
                
            } 
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                
            }
            
            return isValid;
            
        }
    }
}
