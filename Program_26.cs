using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_26
    {
        static void Main()
        {
            Console.Write("\n\n accept a grade and declare the equivalent description:\n");
            Console.Write("...........................................................\n");
            Console.Write("Enter Grade : ");
            char grd = (char)Console.Read();

            if (grd == 'E' || grd == 'e')
            {
                Console.WriteLine("You Have chosen Excellent");
            }
            else if (grd == 'V' || grd == 'v')
            {
                Console.WriteLine("You Have chosen Very Good");
            }
            else if (grd == 'G' || grd == 'g')
            {
                Console.WriteLine("You Have chosen Good");
            }
            else if (grd == 'A' || grd == 'a')
            {
                Console.WriteLine("You Have chosen Average");
            }
            else 
            {
                Console.WriteLine("You Have chosen Fail");
            }
        }
    }
}
