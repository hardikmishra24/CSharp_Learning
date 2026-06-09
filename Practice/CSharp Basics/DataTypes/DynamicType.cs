using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.DataTypes
{
    internal class DynamicType
    {
        // A Dynamic Data Type allows the program to directly run in run-time instead of compile time unlike other programs.
        // It is used whenever we do not know the exact data-type of the values.
        // It allows type conversion and in the below example all the values of x are valid and will be printed so the values of x do not changes every value is valid x =10, hardik, true independently.
        // Cons : No compile time safety. Harder to Debug. Slower. Suggestions are not available. If there is an error in the program it will be reflected only after the progaram runs.
        // Pros : Type changes allowed. Identifies the type of the value by itself. Smaller code.
        // Difference between var and dynamic class is that you cannot define the value again like here x = 10 is allowed and x ="Hardik" is also allowed.
        
        
        public static void Run()
        {
            dynamic x = 10;

            Console.WriteLine(x);

            x = "Hardik";

            Console.WriteLine(x);

            x = true;

            Console.WriteLine(x);
        }
    }
}
