using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program_25
    {
        static void Main()
        {
            double chg,gramt=0,surchg=0,netamt=0;
            Console.Write("\n\nCalculate Custmor Bill:\n");
            Console.Write("...........................................................\n");

            Console.Write("Input Customer ID :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            string nm = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            int unit = Convert.ToInt32(Console.ReadLine());

            if (unit < 200)
            {
                chg = 1.20;
            }
            else if (unit >= 200 && unit < 400)
            {
                chg = 1.50;
            }
            else if (unit >= 400 && unit < 600)
            {
                chg = 1.80;
            }
            else
           
                chg = 2.00;

                gramt = unit * chg;

                if (gramt > 300)

                    surchg = gramt * 15 / 100.0;
                netamt = gramt + surchg;
                if (netamt < 100)
                    netamt = 100;
          
            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer id no                     : {0}\n", id);
            Console.Write("Customer Name                       : {0}\n", nm);
            Console.Write("unit Consumed                       : {0}\n", unit);
            Console.Write("Amount Charges @Rs. {0}  per unit : {1}\n", chg, gramt);
            Console.Write("Surchage Amount                     : {0}\n", surchg);
            Console.Write("Net Amount Paid By the Customer     : {0}\n", netamt);
        }
    }
}
