using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab06_03.Class.CA.UN.AddDepositAndWithdraw
{
    class BankAccount
    {
        public void Populate(decimal balance)
        {
            accNo = BankAccount.NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
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

        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextAccNo = 123;
    }
}