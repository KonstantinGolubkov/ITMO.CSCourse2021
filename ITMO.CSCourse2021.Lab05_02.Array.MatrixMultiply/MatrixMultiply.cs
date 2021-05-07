using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab05_02.Array.MatrixMultiply
{
    class MatrixMultiply
    {
        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];
            result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            return result;
        }

        static void Output(int[,] result)
        {
            for (int r = 0; r < result.GetLength(0); r++)
            {
                for (int c = 0; c < result.GetLength(1); c++)
                {
                    Console.Write("{0} ", result[r, c]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            a[0, 0] = 1; a[0, 1] = 2;
            a[1, 0] = 3; a[1, 1] = 4;

            int[,] b = new int[2, 2];
            b[0, 0] = 5; b[0, 1] = 6;
            b[1, 0] = 7; b[1, 1] = 8;

            int[,] result = new int[2, 2];
            //result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            //result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            //result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            //result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];

            result = MatrixMultiply.Multiply(a, b);

            MatrixMultiply.Output(result);
        }
    }
}
