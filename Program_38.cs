//. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_38
    {
        static void Main()
        {
            Console.Write("\n\nmerge two arrays of same size sorted in ascending order:\n");
            Console.Write(".....................................................................\n");

            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[200];
           
            int i, j, k;

            Console.Write("Input the number of elements to be stored in the first array :");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", s1);
            for (i = 0; i < s1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("Input the number of elements to be stored in the second array :");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", s2);
            for (i = 0; i < s2; i++)
            {
                Console.Write("element - {0} : ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* size of merged array is size of first array and  size of second array */
            int s3 = s1 + s2;

            /*----------------- insert in the third array------------------------------------*/
            for (i = 0; i < s1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < s2; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }
            /*----------------- sort the array in ascending order ---------------------------*/
            for (i = 0; i < s3; i++)
            {
                for (k = 0; k < s3 - 1; k++)
                {

                    if (arr3[k] >= arr3[k + 1])
                    {
                        j = arr3[k + 1];
                        arr3[k + 1] = arr3[k];
                        arr3[k] = j;
                    }
                }
            }
            /*--------------- Prints the merged array ------------------------------------*/
            Console.Write("\nThe merged array in ascending order is :\n");
            for (i = 0; i < s3; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");

        }
    }
}
