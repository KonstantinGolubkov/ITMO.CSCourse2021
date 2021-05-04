using System;

namespace ITMO.CSCourse2021.Lab04_02.Swap
{
    /// This the test harness

    public class Test
    {
        public static void Main()
        {
            int x;
            int y;

            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());

            // Test the Swap method
            Console.WriteLine("Before swap: " + x + "," + y);
            Utils.Swap(ref x, ref y);
            Console.WriteLine("After swap: " + x + "," + y);

        }
    }
}
