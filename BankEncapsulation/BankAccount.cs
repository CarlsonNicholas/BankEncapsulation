using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double amount)
        {
            balance = amount;
        }

        public double Deposit(double amount) 
        { 
            balance += amount;
            return balance;
        }

        public double GetBalance() 
        { 
            return balance;
        }

        public double Withdraw(double amount) 
        {
            balance -= amount;
            return balance;
        }








    }

}
