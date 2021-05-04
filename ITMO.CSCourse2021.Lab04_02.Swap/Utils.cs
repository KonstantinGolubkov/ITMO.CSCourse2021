using System;

namespace ITMO.CSCourse2021.Lab04_02.Swap
{
    public class Utils
    {
        // Exchange two integers, passed by reference

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}
