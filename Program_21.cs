using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_21
    {
        static void Main()
        {
            Console.Write("\n\nCheck whether a triangle is Equilateral, Isosceles or Scalene:\n");
            Console.Write("...........................................................\n");

            Console.Write("Input side 1 of triangle: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c) //a=b=c
            {
                Console.WriteLine("This is an equilateral triangle");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("This is an isosceles triangle");
            }
            else
            {
                Console.WriteLine("This is a scalene triangle");
            }
        }
    }
}
