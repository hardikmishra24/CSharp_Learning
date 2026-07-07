using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Operators.Logical_Operator
{
    internal class Logic_Op
    {
        public static void Run()
        {
            // && AND operator, it is used when both of the conditions are true.
            // || OR operator, it is used when any one of the condition is true.

            Console.WriteLine("What is the temperature :");
            double temp = Convert.ToDouble(Console.ReadLine()); 

            if (temp >= 10 && temp <= 25)
            {
                Console.WriteLine("Temperature is warm outside");
            }

            else if (temp <= -25 || temp >= 50)
            {
                Console.WriteLine("Do not go outside");
            }
    }
}
}
