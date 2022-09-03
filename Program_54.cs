//Write a program in C# Sharp to find sum of rows an columns of a Matrix.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_54
    {
        static void Main()
        {
            Console.Write("\n\n find sum of rows an columns of a Matrix.:\n");
            Console.Write("........................................................\n");

            int[,] arr1 = new int[100, 100];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];

            Console.Write("Input the size of the square matrix : ");
            int  n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input elements in the matrix :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", arr1[i, j]);
                }
                Console.Write("\n");
            }
            /* Sum of rows */
            for (int i = 0; i < n; i++)
            {
                arr2[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    arr2[i] = arr2[i] + arr1[i, j];
                }
            }

            /* Sum of Column */
            for (int i = 0; i < n; i++)
            {
                arr3[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    arr3[i] = arr3[i] + arr1[j, i];
                }
            }

            Console.Write("The sum of row and column of the matrix :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}    ", arr1[i, j]);
                    Console.Write("{0}    ", arr2[i]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}   ", arr3[j]);
            }
            Console.Write("\n\n");
        }
    }
}
