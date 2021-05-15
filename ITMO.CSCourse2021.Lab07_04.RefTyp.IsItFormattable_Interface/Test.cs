using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab07_04.RefTyp.IsItFormattable_Interface
{
    public class Test
    {
        static void Main()
        {
            int i = 4;
            ulong ul = 56;
            string s = "Test";

            Console.WriteLine("int: {0}", Utils.IsItFormattable(i));
            Console.WriteLine("ulong: {0}", Utils.IsItFormattable(ul));
            Console.WriteLine("String: {0}", Utils.IsItFormattable(s));
        }
    }
}
