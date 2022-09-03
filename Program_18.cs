using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_18
    {
        static void Main()
        {
            int total;
            Console.WriteLine("Enter Maths Mark :");
            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Physics Mark :");
            int phy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Chemistry Mark :");
            int chem = Convert.ToInt32(Console.ReadLine());

            total = math + phy + chem;
            Console.WriteLine("Total Of Three Subject ="+total);

            if (math >= 65 && phy >= 55 && chem >= 50 )
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }


            
        }


    }
}
