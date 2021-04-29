using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab02_01.BankAccount
{
    public enum AccountType {Checking, Deposit}

    public class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}
