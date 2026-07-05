using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates
{
    internal class Func_keyword
    {
        public static void Run()
        {

            // Func is a built-in delegate that returns a value.
            // Instead of creating your own delegate, you can use Func.
            // It has zero or more input parameters and one out parameter. The last parameter is considered as an out parameter.
            Func<int, int, int> add = Add; // Here the variable named as add points to the function Add().
            int result = add(10, 20);
            Console.WriteLine(result);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
