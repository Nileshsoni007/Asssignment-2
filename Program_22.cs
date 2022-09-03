using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_22
    {
        static void Main()
        {
            Console.Write("\n\nWrite a C# Sharp program to check whether a triangle can be formed by the given value for the angles:\n");
            Console.Write("...........................................................\n");

            Console.Write("Input side 1 of triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int sum = a + b + c;
            if (sum == 180)
            {
                Console.WriteLine("triangle is valid");
            }
            else {
                Console.WriteLine("Not valid");
            }
            
        }
    }
}
