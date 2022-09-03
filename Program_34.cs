//Write a program in C# Sharp to find the sum of all elements of the array:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_34
    {
        static void Main()
        {
            Console.Write("\n\n  find the sum of all elements of the array:\n");
            Console.Write(".....................................................................\n");

            int[] arr = new int[100];
            int sum = 0;

            Console.Write("Read how many number of values :");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i <n; i++)
            {
                
                 sum=arr[i]+sum;
            }
            Console.Write(sum);
        }
    }
}

