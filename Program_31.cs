using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_31
    {
        static void Main()
        {
            Console.Write("\n\nperform a simple calculation:\n");
            Console.Write("............................................................\n");

            Console.Write("Enter the first Integer: ");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second Integer : ");
            int no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("1-Addition");
            Console.WriteLine("2-Substraction");
            Console.WriteLine("3-Multiplication");
            Console.WriteLine("4-Division");
            Console.WriteLine("5-Exit");
            Console.WriteLine();

            Console.Write("Enter your choice : ");
            int choice= Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition of two digits = " + (no1+no2));
                    break;
                case 2:
                    Console.WriteLine("Substraction of two digits = " + (no1 - no2));
                    break;
                case 3:
                    Console.WriteLine("Multiplication of two digits = " + (no1 * no2));
                    break;
                case 4:
                    Console.WriteLine("Division of two digits = " + (no1 / no2));
                    break;
                case 5:
                    
                    break;
            }
        }
    }
}
