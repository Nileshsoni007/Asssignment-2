using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_40
    {
        static void Main()
        {
            Console.Write("\n\nFind maximum and minimum element in an array :\n");
            Console.Write("........................................................\n");

            int[] arr1 = new int[100];
            

            Console.Write("Enter the how many elements stored in the array :");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
             int  mx = arr1[0];
             int mn = arr1[0];

            for (int i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }
                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Maximum Value is : {0}", mx);
            Console.Write("Minimum Value is : {0}", mn);
        }
    }
}
