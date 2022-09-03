using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_04
    {
        static void Main()
        {
            Console.Write("Enter  the radius of the circle : ");
            int c = Convert.ToInt32(Console.ReadLine());

            double p = (3.14 * c * c);
            Console.WriteLine("Area of Circle = "+p);

            double r = (2*3.14*c);
            Console.WriteLine("Perimeter of Circle  = " + r);
        }
    }
}
