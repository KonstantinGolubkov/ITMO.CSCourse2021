using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab01_01.Greetings
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);

        }
    }
}
