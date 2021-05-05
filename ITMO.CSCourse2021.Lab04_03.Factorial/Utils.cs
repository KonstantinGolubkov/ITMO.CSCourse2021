using System;

namespace ITMO.CSCourse2021.Lab04_03.Factorial
{
    // Factorial calculation and return the result as an out parameter

    public class Utils
    {
        public static bool Factorial(int n, out int answer)
        {
            int k;                                          // Loop counter
            int f;                                          // Working value

            bool ok = true;                                 // True if okay, false if not

            if (n < 0)                                      // Check the input value
                ok = false;

            try                                             // Calculate the factorial value
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; k++)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)                               // If something goes wrong in the calculation, catch it here.
            {                                               // All exceptions are handled the same way:
                f = 0;                                      // set the result to zero
                ok = false;                                 // and return false.
            }
            answer = f;
            return ok;
        }
    }
}
