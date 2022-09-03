//Write a program in C# Sharp to find the second smallest element in an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_48
    {
        static void Main()
        {
            Console.Write("\n\n find the second smallest element in an array:\n");
            Console.Write("........................................................\n");

            int n, j = 0, sml, sml2nd;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("Input {0} elements in the array :\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* find location of the largest element in the array */
            sml = 0;
            for (int i = 0; i < n; i++)
            {
                if (sml > arr1[i])
                {
                    sml = arr1[i];
                    j = i;
                }
            }
            /* ignore the smallest element and find the 2nd smallest element in the array */
            sml2nd = 99999;
            for (int i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* ignoring the smallest element */
                    i--;
                }
                else
                {
                    if (sml2nd > arr1[i])
                    {
                        sml2nd = arr1[i];
                    }
                }
            }
            Console.Write("The Second smallest element in the array is :  {0} \n\n", sml2nd);
        }
    }
}
