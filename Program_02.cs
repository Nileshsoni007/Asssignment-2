using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_02
    {
        static void Main()
        {
            Console.WriteLine("Enter A Number : ");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter A Width : ");
            int width = Convert.ToInt32(Console.ReadLine());

            int k = width;
            for (int i = 0; i < k; i++)
            {
                for (int j =0; j < width; j++)
                {
                    Console.Write(no);
                }
                Console.WriteLine();
                width--;
            }
        }
    }
}
