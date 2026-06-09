using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Loops
{
    internal class LearnWhile_loop
    {
        //We usually use while loop when we do not know how many times a program will run.
        public static void Run()
        {
            int i = 0; 

            while (i < 10)
            {
                Console.WriteLine($"Value of i: {i}");
                i++; 
            }
        }

    }
}

