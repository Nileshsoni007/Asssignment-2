
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_01
    {
        static void Main()
        {
            char[] ch = new char[3];
            Console.WriteLine("Enter Character : ");
            for(int i=0; i<=2; i++)
            {
                ch[i] = (char) Console.Read();
                
            }
            Console.WriteLine();
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(ch[i]);
            }
        }
    }
}
