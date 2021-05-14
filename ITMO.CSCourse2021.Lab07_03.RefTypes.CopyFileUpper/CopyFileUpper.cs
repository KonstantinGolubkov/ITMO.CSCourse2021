using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ITMO.CSCourse2021.Lab07_03.RefTypes.CopyFileUpper
{
    // Class to create an upper case copy of a file

    class CopyFileUpper
    {
        static void Main()
        {
            string sFrom, sTo;
            StreamReader srFrom;
            StreamWriter swTo;

            Console.WriteLine("Enter name input file:");
            sFrom = Console.ReadLine();
            Console.WriteLine("Enter name output file:");
            sTo = Console.ReadLine();
        }
    }
}
