using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_39
    {
        static void Main()
        {
            Console.Write("\n\ncount the frequency of each element of an array:\n");
            Console.Write(".....................................................................\n");

            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
               
            Console.Write("Input the number of elements to be stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                arr2[i] = -1;
            }
            for (int i = 0; i < n; i++)
            {
               int ctr = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        arr2[j] = 0;
                    }
                }
                if (arr2[i] != 0)
                {
                    arr2[i] = ctr;
                }
            }
            Console.Write("\nThe frequency of all elements of the array : \n");
            for (int i = 0; i < n; i++)
            {
                if (arr2[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], arr2[i]);
                }
            }
        }
    }
}
