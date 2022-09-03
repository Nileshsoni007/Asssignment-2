using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_32
    {
        static void Main()
        {
            Console.Write("\n\nstore elements in an array and print it:\n");
            Console.Write("............................................................\n");

            int[] arr = new int[10];
             

            Console.Write("\nInput 10 elements in the array :\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");
        }
    }
}
