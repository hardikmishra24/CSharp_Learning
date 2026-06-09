using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Loops
{
    internal class LearnDoWhile
    {
        public static void Run() {
            int i = 0;
            do {
                Console.WriteLine($"value of i is -> {i}");
                i++;
               }

            while (i < 5);
        }
    }
}