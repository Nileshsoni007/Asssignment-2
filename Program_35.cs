//Write a program in C# Sharp to copy the elements one array into another array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_35
    {
        static void Main()
        {
            Console.Write("\n\n copy the elements one array into another array:\n");
            Console.Write(".....................................................................\n");

            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            
            Console.Write("Read how many number of values in array :");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in first array are: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n");
            for (int i = 0; i < n; i++)
            {
                arr2[i]=arr1[i];
            }
            Console.Write("\nElements in second array are: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }

        }
    }
}
