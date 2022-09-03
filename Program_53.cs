//Write a program in C# Sharp to find the sum of left diagonals of a matrix
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_53
    {
        static void Main()
        {
            Console.Write("\n\n find the sum of left diagonals of a matrix:\n");
            Console.Write("........................................................\n");

            int i, j, sum = 0, n, m = 0;
            int[,] arry = new int[20, 20];

            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            Console.Write("Input values in the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arry[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0}  ", arry[i, j]);
                Console.Write("\n");
            }
            // calculate the sum of left diagonals
            for (i = 0; i < n; i++)
            {
                m = m - 1;
                for (j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum = sum + arry[i, j];
                    }
                }
            }
            Console.Write("Addition of the  left Diagonal elements is :{0}\n", sum);
        }
    }
}
