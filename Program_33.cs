//Write a program in C# Sharp to read n number of values in an array and display it in reverse :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_33
    {
        static void Main()
        {
            Console.Write("\n\ns read n number of values in an array and display it in reverse:\n");
            Console.Write(".....................................................................\n");

            int[] arr = new int[100];
           
            Console.Write("Read how many number of values :");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = n-1; i > 0; i--)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }
    }
}
