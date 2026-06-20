using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates
{

    internal class Outparam
    {
        // Output parameter(out) is used when a method needs to return a value through a parameter instead of using the normal return statement.
       
        public delegate void SampleDelegate(out int text);

        public static void Run()
        {
            SampleDelegate del = new SampleDelegate(Method1);
            del += Method2;

            int delegateoutparmetervalue;

            del(out delegateoutparmetervalue); // First this value is initialized to 1 and then to 2.

            Console.WriteLine(delegateoutparmetervalue);
            // Output Answer will be the value of the second function and not the first one.
        }

        public static void Method1(out int Number) // The value 1 is stored in the variable Number.
        {
            Number = 1;
        }

        public static void Method2(out int Number) // The value 2 is stored in the variable Number.
        {
            Number = 2;
        }


    }
}
