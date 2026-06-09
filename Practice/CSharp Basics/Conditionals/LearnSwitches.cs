using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Conditionals
{
    internal class LearnSwitches
    {
        public static void Run()
        {
            int x = 6;
            switch (x)
            {
                case 0:
                    Console.WriteLine("Print 0");
                    break;

                case 3:
                    Console.WriteLine("Print 3");
                    break;

                case 6:

                    Console.WriteLine("Print 6");
                    break;


                default:
                    Console.WriteLine("This is default");
                    break;
            }
        }
    }
}