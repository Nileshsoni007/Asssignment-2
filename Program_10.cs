using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_10
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number : ");
            int no2 = Convert.ToInt32(Console.ReadLine());

            if (no1 == no2)
            {
                Console.WriteLine("Both Value Are Equal ");
            }
            else
            {
                Console.WriteLine("both value are not equal");
            }
        }
    }
}
