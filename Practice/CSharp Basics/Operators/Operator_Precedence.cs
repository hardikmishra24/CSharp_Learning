using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Operators
{
    internal class Operator_Precedence
    {
        public static void Run() { 
        int a = 5 + 3 * 3;
        int b = 5 + 3 * 3 / 2;
        int c = (5 + 3) * 3 / 2;
        int d = (3 * 3) * (3 / 3 + 5);

       
        
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

        }
    }
}