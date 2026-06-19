using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LearnDelegates
{
    internal class Action_key
    {
        // Action is a built-in delegate used for methods that do not return anything (void).
        public static void Run()
        {
            Action<string> greet = Greet;
            greet("Hardik");
        }


        public static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
