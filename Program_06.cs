using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_06
    {
        static void Main()
        {
            Console.WriteLine("Enter The Radius Of The Sphere : ");
            double r = Convert.ToDouble(Console.ReadLine());

            double s = (4 * 3.14 *( r * r));
            double v = (4/3*3.14*(r*r*r));

            Console.WriteLine("surface = "+s);
            Console.WriteLine("volume = " + v);
        }
    }
}
