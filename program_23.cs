using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class program_23
    {
        static void Main()
        {
            Console.Write("\n\nWrite a C# Sharp program to check whether an alphabet is a vowel or consonant:\n");
            Console.Write("...........................................................\n");


            Console.WriteLine("Enter the character : ");
            char ch = (char)Console.Read();

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("The alphabet is a Vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant");
            }
        }
    }
}
