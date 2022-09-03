//Write a program in C# Sharp for subtraction of two Matrices
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_51
    {
        static void Main()
        {
            Console.Write("\n\n Subtraction of two Matrices of same size:\n");
            Console.Write("........................................................\n");

            int[,] arr1 = new int[100, 100];
            int[,] arr2 = new int[100, 100];
            int[,] arr3 = new int[100, 100];

            Console.Write("Enter  the size of the square matrix (less than 5): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input values in the first matrix :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Input values in the second matrix :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\nThe First matrix is :\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }

            Console.Write("\nThe Second matrix is :\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr2[i, j]);
                }
            }
            /* calculate the Subtraction of the matrix */
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            Console.Write("\nThe Subtraction of two matrix is : \n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", arr3[i, j]);
                }
            }
            Console.Write("\n\n");


        }
    }
}
