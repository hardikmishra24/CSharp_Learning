using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.CSharp_Basics.ExtensionMethods;
namespace ConsoleApp1.CSharp_Basics.ExtensionMethods
{
    internal class Size
    {
        public static void Run()
        {
            int i = 10;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine("Result :" + result);
        }
    }
}
