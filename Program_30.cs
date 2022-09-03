using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_30
    {
        static void Main()
        {

            Console.Write("\n\nread any Month Number in integer and display the number \r\nof days for this month:\n");
            Console.Write("...........................................................................\n");

            Console.Write("Enter the Input : ");
            int no = Convert.ToInt32(Console.ReadLine());

            switch (no)
            {
                case 1:
                    Console.WriteLine("January Month Contain 31 Days");
                    break;
                case 2:
                    Console.WriteLine("Feburary Month Contain 28 Days");
                    break;
                case 3:
                    Console.WriteLine("March Month Contain 31 Days");
                    break;
                case 4:
                    Console.WriteLine("AprilMonth Contain 31 Days");
                    break;
                case 5:
                    Console.WriteLine("May Month Contain 31 Days");
                    break;
                case 6:
                    Console.WriteLine("June Month Contain 30 Days");
                    break;
                case 7:
                    Console.WriteLine("July Month Contain 31 Days");
                    break;
                case 8:
                    Console.WriteLine("August Month Contain 31 Days");
                    break;
                case 9:
                    Console.WriteLine("September Month Contain 30 Days");
                    break;
                case 10:
                    Console.WriteLine("October Month Contain 31 Days");
                    break;
                case 11:
                    Console.WriteLine("November Month Contain 30 Days");
                    break;
                case 12:
                    Console.WriteLine("December Month Contain 31 Days");
                    break;
                default:
                    Console.Write("invalid digit. \nPlease try again ....\n");
                    break;
            }
        }
    }
}
