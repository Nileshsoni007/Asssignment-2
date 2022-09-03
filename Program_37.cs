//Write a program in C# Sharp to print all unique elements in an array
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_37
    {
        static void Main()
        {
            Console.Write("\n\n print all unique elements in an array:\n");
            Console.Write(".....................................................................\n");

            int[] items = new int[100];
            int n = items.Length;

            Console.Write("Read how many number of values in array :");
            int value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.Write("element - {0} : ", i);
                items[i] = Convert.ToInt32(Console.ReadLine());
            }



         

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
