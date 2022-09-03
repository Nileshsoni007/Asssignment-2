//Write a program in C# Sharp to delete an element at desired position from an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_46
    {
        static void Main() 
        {
            Console.Write("\n\n delete an element at desired position from an array:\n");
            Console.Write("........................................................\n");

            int i, pos, n;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nInput the position where to delete: ");
            pos = Convert.ToInt32(Console.ReadLine());
            
            i = 0;
            while (i != pos - 1)
                i++;
            
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");
        }
    }

}
