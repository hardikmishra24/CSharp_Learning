using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.CSharp_Basics.ExtensionMethods;  // Here we have to include the namespace of the extension method where the method was made to use the method.
namespace ConsoleApp1.CSharp_Basics.ExtensionMethods
{
    internal class Size
    {
        public static void Run()
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);  // Implementing the extension method

            Console.WriteLine("Result :" + result);
        }
    }
}
