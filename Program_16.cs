using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_16
    {
        static void Main()
        {
            Console.WriteLine("Enter The Person Height(CM)");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height == 150)
            {
                Console.WriteLine("The person is Average height");
            }
            else if (height < 150)
            {
                Console.WriteLine("The person is Dwarf");
            }
            else
            {
                Console.WriteLine("The person is tall");
            }
        }
    }
}
