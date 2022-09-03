//Write a program in C# Sharp to insert New value in the array (unsorted list ).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_45
    {
        static void Main()
        {
            int[] arr1 = new int[10];
            
            Console.Write("\n\nInsert New value in the unsorted array : \n");
            Console.Write("................................................\n");
            Console.Write("Enter the how many elements stored in the array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            /* Stored values into the array*/
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Input the value to be inserted : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted :");
           int  p = Convert.ToInt32(Console.ReadLine());

            Console.Write("The current list of the array :\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }
            /* Move all data at right side of the array */
            for (int i = n; i >= p; i--)
            {
                arr1[i] = arr1[i - 1];
                /* insert value at given position */
                arr1[p - 1] = x;
            }
            Console.Write("\n\nAfter Insert the element the new list is :\n");
            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0} ", arr1[i]);
                Console.Write("\n\n");
            }

        }

    }
}
