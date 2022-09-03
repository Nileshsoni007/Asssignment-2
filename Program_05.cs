using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_05
    {
        static void Main()
        {
            Console.Write("Input distance(metres): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input timeSec(hour): ");
            double hour = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input timeSec(minutes): ");
            double min = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input timeSec(seconds): ");
            double sec = Convert.ToDouble(Console.ReadLine());

            double timeSec = (hour * 3600) + (min * 60) + sec;
            double mps = distance / timeSec;
            double kph = (distance / 1000.0) / (timeSec / 3600.0);
            double mph = kph / 1.609;

            Console.WriteLine("Your speed in metres/sec is {0}", mps);
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}
