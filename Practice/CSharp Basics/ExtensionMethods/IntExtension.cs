using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.ExtensionMethods
{

    // Extension methods are methods that let you add new functionality(methods) to an existing class without modifying its source code or creating a derived class.
    // For example adding a method in a predefined class like string or int.
            public static class IntExtension  // The class must be static
        {
            public static bool IsGreaterThan(this int i, int value)
            {
                return i > value;
            }
        }
        
    }

