using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Conditionals
{
    internal class If_Else
    {
        public static void Run()
        {
            int i = 10; int j = 20;

            if (i > j)
            {
                Console.WriteLine(i);
            }

            else if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            else
            {
                Console.WriteLine("i is equal to j");
            }


        }
    }
}
