using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates
{
    internal class Anonymous_Method
    {
        public static void Run()
        {
            Action greet = delegate ()
            {
                Console.WriteLine("Hello");
            };

            greet();
        }
    }
}
