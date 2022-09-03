using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_20
    {
        static void Main()
        {
            Console.Write("\nAccept a temperature in centigrade and display a suitable message:\n");
            Console.Write("--------------------------------------------------------------------\n");

            Console.Write("Input days temperature : ");
            int tmp = Convert.ToInt32(Console.ReadLine());
            if (tmp < 0)
            {
                Console.Write("Freezing weather");
            }
            else if (tmp < 10)
            {
                Console.Write("Very cold weather");
            }
            else if (tmp < 20)
            {
                Console.Write("Cold weather");
            }
            else if (tmp < 30)
            {
                Console.Write("Normal in temp");
            }
            else if (tmp < 40)
            {
                Console.Write("Its Hot");
            }
            else
            {
                Console.Write("Its very hot");
            }
        }
    }
}
