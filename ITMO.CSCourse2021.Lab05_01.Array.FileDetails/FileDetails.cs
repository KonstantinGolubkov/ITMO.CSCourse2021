using System;                               //Console
using System.Collections.Generic;
using System.IO;                            //FileStream, FileReader
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab05_01.Array.FileDetails
{
    class FileDetails
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
