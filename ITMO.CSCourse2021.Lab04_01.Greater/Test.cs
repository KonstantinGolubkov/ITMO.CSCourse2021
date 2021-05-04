using System;

namespace ITMO.CSCourse2021.Lab04_01.Greater
{
    /// This the test harness

    public class Test
    {
        public static void Main()
        {
            int x; 
            int y; 
            int greater; // Result from Greater()

            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            // Test the Greater( ) method
            greater = Utils.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);
        }

    }
}
