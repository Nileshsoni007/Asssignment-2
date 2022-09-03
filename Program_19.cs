using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_19
    {
        static void Main()
        {

            Console.Write("Enter the Roll Number of the student");
            int rn = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Name of the Student");
            string nm = Console.ReadLine();

            Console.Write("Enter First Subject mark : ");
            int sub1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Subject mark : ");
            int sub2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Subject mark : ");
            int sub3 = Convert.ToInt32(Console.ReadLine());

            int total = sub1 + sub2 + sub3;
            double per = total / 3.0;

            Console.WriteLine("Roll No ={0}  ", rn);
            Console.WriteLine("Student Name ={0}  ", nm);
            Console.WriteLine("Total Mark= " + total);
            Console.WriteLine("Percentage = " + per);

            if (per >= 60)
            {
                Console.WriteLine("Student Get First Class");
            }
            else if (per < 60 && per >= 48)
            {
                Console.WriteLine("Student Get Second Class");
            }
            else if (per < 48 && per >= 36)
            {
                Console.WriteLine("Student Get Pass ");
            }
            else
            {
                Console.WriteLine("Student Fail");

            }
            

        }
    }
}
