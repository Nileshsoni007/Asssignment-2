using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_11
    {
        static void Main()
        {
            Console.Write("Enter First Number : ");
            int no1 = Convert.ToInt32(Console.ReadLine());

            
            if (no1%2==0)
            {
                Console.WriteLine("this is even number");
            }
            else
            {
                Console.WriteLine("This is odd number");
            }
        }
    }
}
