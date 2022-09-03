using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment2
{
    internal class Program_3
    {
        static void Main()
        {

            Console.Write("Enter First number : ");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter operation  : ");
            String op = Console.ReadLine();

            Console.Write("Enter second  number : ");
            int no2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine("Sum Of Two numbers : " + (no1 + no2));
                    break;
                case "-":
                    Console.WriteLine("Sum Of Two numbers : " + (no1 - no2));
                    break;
                case "*":
                    Console.WriteLine("Mul Of Two numbers : " + (no1 * no2));
                    break;
                case "/":
                    Console.WriteLine("Sum Of Two numbers : " + (no1 / no2));
                    break;

            //        default:
            //        Console.WriteLine("Invalid Option");
            }
        }
    }
}
