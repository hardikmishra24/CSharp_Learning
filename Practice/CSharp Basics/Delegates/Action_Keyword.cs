using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates
{
    internal class Action_Keyword
    {
        // Action is a built-in delegate used for methods that do not return anything (void).
        public static void Run()
        {
            Action<string> greet = Greet;  // Delegate named greet which is mapped to function Greet. <string> denotes that the function which implements this delegate should take string as input parameters.
            greet("Hardik");
        }

        public static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
