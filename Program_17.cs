using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_17
    {
        static void Main()
        { 
            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the first number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  second number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The first Number is the greatest among three");
                }
                else
                {
                    Console.Write("The third Number is the greatest among three");
                }
            }
            else if (num2 > num3)
            {
                Console.Write("The second Number is the greatest among three");
            }
            else
            {
                Console.Write("The third Number is the greatest among three");
            }
        }

    }
}
