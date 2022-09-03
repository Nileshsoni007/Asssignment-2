//Write a program in C# Sharp to sort elements of array in ascending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_42
    {
        static void Main()
        {
            Console.Write("\n\n sort elements of array in ascending order :\n");
            Console.Write("........................................................\n");

            int[] arr1 = new int[100];
            int tmp;

            Console.Write("Enter the how many elements stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nsorted elements by ascending : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");
        }
    }
}
