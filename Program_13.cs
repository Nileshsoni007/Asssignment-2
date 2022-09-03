using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_13
    {
        static void Main()
        {

            int year;
    
            Console.Write("Check whether a given year is leap year or not:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an year : ");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }
            else if ((year % 100) == 0)
            {
                Console.WriteLine("{0} is not a leap year.\n", year);
            }
            else if ((year % 4) == 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.\n", year);
            }
        }
    }
}
