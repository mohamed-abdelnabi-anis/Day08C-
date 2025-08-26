using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08C_
{
    internal struct Account
    {
        private int accountId;
        private string accountHolder;
        private decimal balance;

       
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }

        public string AccountHolder
        {
            get { return accountHolder; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    accountHolder = value;
                else
                    Console.WriteLine("Account holder name cannot be empty.");
            }
        }

        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                    balance = value;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }
        }

        
        public Account(int id, string holder, decimal initialBalance)
        {
            accountId = id;
            accountHolder = holder;
            balance = initialBalance >= 0 ? initialBalance : 0; 
        }

        public void Display()
        {
            Console.WriteLine($"ID: {AccountId}, Holder: {AccountHolder}, Balance: {Balance}");
        }
    }
}

