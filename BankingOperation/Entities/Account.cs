using System;
using System.Collections.Generic;
using System.Text;
using BankingOperation.Exceptions;

namespace BankingOperation.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
                                
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw (double amount)
        {

            if (amount > WithdrawLimit)
            {
                throw new DomainExceptions("The amount exceeds withdraw limit");
            }

            if ( amount > Balance)
            {
                throw new DomainExceptions("Not enough balance");
            }
          
            else
            {
                Balance -= amount;
            }
                        
        }

        public override string ToString()
        {
            return "Number: "
                + Number
                + " - "
                + "Holder: "
                + Holder
                + " - "
                + "Balance"
                + Balance; 
        }
    }
}
