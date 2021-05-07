using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSCourse2021.Lab05_02.Array.MatrixMultiply
{
    class MatrixMultiply
    {
        static void Input(int[,] dst)
        {
            Console.Write("Enter the value of the matrix [0,0]\t");
            string s00 = Console.ReadLine();
            dst[0, 0] = int.Parse(s00);
            Console.Write("Enter the value of the matrix [0,1]\t");
            string s01 = Console.ReadLine();
            dst[0, 1] = int.Parse(s01);
            Console.Write("Enter the value of the matrix [1,0]\t");
            string s10 = Console.ReadLine();
            dst[1, 0] = int.Parse(s10);
            Console.Write("Enter the value of the matrix [1,1]\t");
            string s11 = Console.ReadLine();
            dst[1, 1] = int.Parse(s11);

            Console.WriteLine();
        }

        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] result = new int[2, 2];

            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    result[r, c] += a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }

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
            int[,] b = new int[2, 2];
            int[,] result = new int[2, 2];

            MatrixMultiply.Input(a);

            MatrixMultiply.Input(b);

            result = MatrixMultiply.Multiply(a, b);

            MatrixMultiply.Output(result);
        }
    }
}
