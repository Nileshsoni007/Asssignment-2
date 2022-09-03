using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment2
{
    internal class Program_07
    {
        static void Main()
        {
            char symbol;

            Console.WriteLine("Enetr a Symbol : ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') || (symbol == 'o') || (symbol == 'u'))
            {
                Console.WriteLine("It's a lowercase vowel.");
            }
            else if ((symbol >= '0') && (symbol <= '9'))
            {
                Console.WriteLine("It's a digit.");
            }
            else
            {
                Console.Write("It's another symbol.");
            }
        }
    }
}
