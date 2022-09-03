//Write a programin C# Sharp to separate odd and even integers in separate arrays.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_41
    {
        static void Main()
        {
            Console.Write("\n\n separate odd and even integers in separate arrays :\n");
            Console.Write("........................................................\n");

            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int j = 0,k=0;

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
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.Write("\nOdd Numbers are :" );
            for (int i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.Write("\n\nEven Numbers : ");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");
        }
    }
}
