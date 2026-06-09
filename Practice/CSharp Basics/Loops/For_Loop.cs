using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Loops
{
    internal class For_Loop
    {
        public static void Run()
        {
            for (int i = 0; i < 5; i++) {
               //Console.WriteLine("Value of i{0}", i);
               Console.WriteLine($"Value of i: {i}");

            }
        }
    }
}