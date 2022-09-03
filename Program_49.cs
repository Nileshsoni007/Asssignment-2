//. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_49
    {
        static void Main()
        {
            Console.Write("\n\n 2D array of size 3x3 and print the matrix.:\n");
            Console.Write("........................................................\n");

            int[,] arr = new int[3, 3];

            Console.Write("Input value in the matrix :\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                    Console.Write("{0}\t", arr[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}
