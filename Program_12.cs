using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_12
    {
        static void Main()
        {
            Console.Write("Enter Number : ");
            int no1 = Convert.ToInt32(Console.ReadLine());
            if (no1 >=0)
            {
                Console.WriteLine("{0} is Positive Number",no1);
            }
            else
            {
                Console.WriteLine("{0} is Negative Number", no1);
            }
        }
    }
}
