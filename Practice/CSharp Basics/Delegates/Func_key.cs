using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates
{
    internal class Func_key
    {
        public static void Run()
        {

            // Func is a built-in delegate that returns a value.
            // Instead of creating your own delegate, you can use Func.


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
