﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ITMO.CSCourse2021.Lab08_03.BankAccount.Dispose
{
    sealed class BankAccount : IDisposable
    {
        bool disposed = false;

        private Queue tranQueue = new Queue();

        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;

        public void Dispose()
        {
            if (!disposed)
            {
                StreamWriter swFile = File.AppendText("Transactions.Dat");
                swFile.WriteLine("Account number is {0}", accNo);
                swFile.WriteLine("Account balance is {0}", accBal);
                swFile.WriteLine("Account type is {0}", accType);
                swFile.WriteLine("Transactions:");
                foreach (BankTransaction tran in tranQueue)
                {
                    swFile.WriteLine("Date/Time: {0}\tAmount:{1}", tran.When(), tran.Amount());
                }
                swFile.Close();
                disposed = true;
                GC.SuppressFinalize(this);
            }
        }

        ~BankAccount()
        {
            Dispose();
        }

        public Queue Transactions()
        {
            return tranQueue;
        }

        public BankAccount()
        {
            accNo = BankAccount.NextNumber();
            accBal = 0;
            accType = AccountType.Checking;
        }

        public BankAccount(AccountType aType)
        {
            accNo = BankAccount.NextNumber();
            accBal = 0;
            accType = aType;
        }

        public BankAccount(decimal aBal)
        {
            accNo = BankAccount.NextNumber();
            accBal = aBal;
            accType = AccountType.Checking;
        }

        public BankAccount(AccountType aType, decimal aBal)
        {
            accNo = BankAccount.NextNumber();
            accBal = aBal;
            accType = aType;
        }

        public long Number()
        {
            return accNo;
        }

        public decimal Balance()
        {
            return accBal;
        }

        public string Type()
        {
            return accType.ToString();
        }

        private static long NextNumber()
        {
            return nextAccNo++;
        }

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            BankTransaction tran = new BankTransaction(amount);
            tranQueue.Enqueue(tran);
            return accBal;
        }

        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
            }
            return sufficientFunds;
        }
    }
}
