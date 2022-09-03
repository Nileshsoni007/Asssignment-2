//. Write a program in C# Sharp to count a total number of duplicate elements in an array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_36
    {
        static void Main()
        {
            Console.Write("\n\n count a total number of duplicate elements in an array:\n");
            Console.Write(".....................................................................\n");

            int[] arr1 = new int[100];
            

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
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        Console.WriteLine("Duplicat Elements : " + arr1[i]);                                           
                    }
                    arr1[i] = 0;
                }
            }
        }
    }
}
