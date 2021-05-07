using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab06_01.Class.CreateAccount
{
    class CreateAccount
    {
        static void Main()
        {
            BankAccount berts = NewBankAccount();
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created;

            Console.Write("Enter the account number   : ");
            long number = long.Parse(Console.ReadLine());

            Console.Write("Enter the account balance! : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.accNo = number;
            created.accBal = balance;
            created.accType = AccountType.Checking;

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.accNo);
            Console.WriteLine("Account balance is {0}", toWrite.accBal);
            Console.WriteLine("Account type is {0}", toWrite.accType.ToString());
        }

    }
}
