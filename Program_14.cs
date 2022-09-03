using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_14
    {
        static void Main()
        {
            Console.WriteLine("Enter Age Of Candidate");
            int age=Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote");
            }
            else
            { 
                Console.WriteLine("You are not eligible for casting your vote");
            }
        }
    }
}
