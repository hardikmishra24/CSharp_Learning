using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Tuples   
{
    internal class learnTuple
    {
        //Tuple are of reference type.
        public static void Run()

            // Tuple is a data structure used to enter different types of data types which includes string and integer in a single value.
        {
            var person = Tuple.Create(1, "Steve", "h", 4, true, "4", 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);

            Console.WriteLine(person.Rest);                  // Returned value ((8, 9, 10, 11, 12, 13)) 
            Console.WriteLine(person.Rest.Item1);            // Returned value (8, 9, 10, 11, 12, 13) 
            Console.WriteLine(person.Rest.Item1.Item1);      // Returned value 8
            Console.WriteLine(person.Rest.Item1.Item2);      // Returned value 9

            /*
             
            Tuple Limitations:
            The Tuple is a reference type and not a value type. It allocates on heap and could result in CPU intensive operations.
            The Tuple is limited to include eight elements. You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.
             */
        }
    }
}
