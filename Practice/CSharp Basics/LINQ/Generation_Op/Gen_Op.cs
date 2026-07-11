using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Generation_Op
{
   // Generation operators are used to create a new sequence instead of querying an existing one.
    internal class Gen_Op
    {
        public static void Run()
        {
            // Empty() creates an empty collection.
            var emptyResult = Enumerable.Empty<int>();
            Console.WriteLine("Empty");
            foreach (var item in emptyResult)
            {
                Console.Write(item + " ");
            }


            // Range() creates a sequence of numbers.
            var rangeresult = Enumerable.Range(0, 10);
            Console.WriteLine("Range");
            foreach(var item in rangeresult)
            {
                Console.Write(item + " ");
            }


            // Repeat() repeats the same value multiple times.
            var repeatresult = Enumerable.Repeat("Hello", 10);
            Console.WriteLine("Repeat");
            foreach( var item in repeatresult)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            List<int> list1 = new List<int>();
            // DefaultIfEmpty() returns a default value if the collection is empty.
            var defaultempty = list1.DefaultIfEmpty();
            Console.WriteLine("default if empty");
            foreach(var item in defaultempty)
            {
                Console.Write(item + " ");
            }


            // DefaultIfEmpty(value) returns the specified value if the collection is empty.
            var defaultemptyvalue = list1.DefaultIfEmpty(0000);
            foreach (int item in defaultemptyvalue)
            { 
                  Console.WriteLine(item + " ");
            }
        }
    }
}
