using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
            
        {
            int X;
            string continuee;
            do { 
            Console.WriteLine("Enter a numerical grade ");
            string z = Console.ReadLine();
            X = Convert.ToInt32(z);
            if (X > 88 && X <= 100)
            {
                Console.WriteLine("letter grade is A");
            }

            else if (X > 80 && X <= 88)
            {
                Console.WriteLine("letter grade is B");
            }
            else if
                (X <= 79 && X > 67)
            {

                Console.WriteLine("letter grade is C");
            }
            else if (X <= 66 && X > 60)
            {
                Console.WriteLine("letter grade is D");
            }
            else if
                (X <= 60 && X > 0)
            {
                Console.WriteLine("letter grade is F");
            }
            else
            { Console.WriteLine("enter only from 0 to 100"); }

                Console.WriteLine("you want to continue y/n ");

                continuee = Console.ReadLine();

            }

            while (continuee == "y");






        }
    }
}
