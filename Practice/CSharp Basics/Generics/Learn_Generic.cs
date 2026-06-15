using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Generics
{
    internal class Learn_Generic
    //Generic means a general form not any specific type. It allows you to create a class, method, delegate, or interface that can work with any data type. The type is specified when the class, method, delegate, or interface is instantiated or called.
    // A generic type is defined useing angle brackets <> and a type parameter.

    // Disadvantages
    // generalization makes code difficult to understand and maintain.
    // A generic class can include generic fields. However, it cannot be initialized.

    ///Advantages of Generics
    //Generics increase the reusability of the code.You don't need to write code to handle different data types.
    //Generics are type - safe.You get compile-time errors if you try to use a different data type than the one specified in the definition.
    //Generic has a performance advantage because it removes the possibilities of boxing and unboxing.

    {
        
        
        public static void Run()
        {
            Print<int>(100);

            Print<string>("Hardik");

            Print<double>(99.99);
        }

        public static void Print<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}

