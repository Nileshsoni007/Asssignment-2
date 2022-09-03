using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_15
    {
        static void Main()
        {
            int m, n;
            Console.Write("\n\n");
            Console.Write("Display the value of n is 1,0 and -1 for the value of er m:\n");
            Console.Write("----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the  value of m :");
            m = Convert.ToInt32(Console.ReadLine());
            if (m != 0)
            {
                if (m > 0)
                {
                    n = 1;
                }
                else
                {
                    n = -1;
                }
            }
            else
            {
                n = 0;
            }
            Console.Write("The value of m = {0} \n", m);
            Console.Write("The value of n = {0} \n\n", n);
        }
    }
}
