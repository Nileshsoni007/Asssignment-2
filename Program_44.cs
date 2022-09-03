//Write a program in C# Sharp to insert New value in the array (sorted list ).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_44
    {
        static void Main()
        {
            Console.Write("\n\n insert New value in the array (sorted list ) :\n");
            Console.Write("........................................................\n");

            int[] arr1 = new int[100];
            int p=0;

            Console.Write("\nEnter the how many elements stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nInput {0} elements in the array :\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the value to be inserted : ");
           int  newval = Convert.ToInt32(Console.ReadLine());

            for (int i=0;i<n;i++)
            {
                Console.WriteLine("{0}", arr1[i]);
            }
            for (int i = 0; i < n; i++)
            {
                if (newval < arr1[i])
                {
                    p = i;
                    break;
                }
            }
            for (int i = n; i >= p; i--)
            {
                arr1[i] = arr1[i - 1];
                arr1[p] = newval;
            }
            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0} ", arr1[i]);
            }
            Console.Write("\n");
        }
    }
}
