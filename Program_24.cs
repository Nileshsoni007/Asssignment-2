using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_24
    {
        static void Main()
        {
            Console.Write("\n\nWrite a C# Sharp program to calculate profit and loss on a transaction.:\n");
            Console.Write("...........................................................\n");

            Console.Write("Enter Cost Price : ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Selling Price : ");
            int s = Convert.ToInt32(Console.ReadLine());

            if (s > c)
            {
                int diff = s - c;
                Console.WriteLine("profit = " + diff);
            }
            else if (s < c)
            {
                int diff = c - s;
                Console.WriteLine("Cost = " + diff);
            }
        }
    }
}
