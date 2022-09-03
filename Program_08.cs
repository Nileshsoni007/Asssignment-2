using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_08
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number : ");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int no2 = Convert.ToInt32(Console.ReadLine());

            if ((no1 % 2 == 0) || (no2 % 2 == 0))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
