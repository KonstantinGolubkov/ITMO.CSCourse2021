using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab04_03.Factorial
{
    public class Test
    {
        static void Main()
        {
            int f;                                                      // Factorial result
            bool ok;                                                    // Factorial success or failure
            int x;

            Console.WriteLine("Enter number for factorial:");           // Get input for factorial
            x = int.Parse(Console.ReadLine());

            ok = Utils.Factorial(x, out f);                             // Test the factorial function

            if (ok)                                                     // Output factorial results
                Console.WriteLine("Factorial(" + x + ") = " + f);
            else
                Console.WriteLine("Cannot compute this factorial");
        }
    }
}
