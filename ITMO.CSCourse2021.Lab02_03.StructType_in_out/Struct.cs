﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab02_03.StructType_in_out
{
        public enum AccountType { Checking, Deposit }

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }
         
    class Struct
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            Console.Write("Enter account number: ");
            goldAccount.accNo = long.Parse(Console.ReadLine());

            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
        }
    }
}
