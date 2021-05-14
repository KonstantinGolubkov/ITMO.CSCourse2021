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

            Console.WriteLine("Copy from {0} to {1}", sFrom, sTo);

            srFrom = new StreamReader(sFrom);       //create a new object of type StreamReader
            swTo = new StreamWriter(sTo);           //create a new object of type StreamWriter

            while (srFrom.Peek() != -1)                 //StreamReader.Peek method from System.IO
            {
                string sBuffer = srFrom.ReadLine();     //StreamReader.ReadLine method from System.IO
                sBuffer = sBuffer.ToUpper();            //String.ToUpper method from System
                swTo.WriteLine(sBuffer);                //StreamWriter.WriteLine method from System.IO
            }
            srFrom.Close();                         //close input stream
            swTo.Close();                           //close output stream

        }
    }
}
