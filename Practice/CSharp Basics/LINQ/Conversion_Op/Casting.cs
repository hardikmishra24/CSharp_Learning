using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Conversion_Op
{
    internal class Casting
    {
        public static void Run()
        {
            // ArrayList containing different data types.

            ArrayList numbers = new ArrayList()
            {
                10,
                20,
                30,
                40
            };

            ArrayList mixedData = new ArrayList()
            {
                10,
                "Hello",
                20,
                true,
                30,
                "World"
            };

            
            // Cast() converts every element to the specified type.
            var castResult = numbers.Cast<int>();

            Console.WriteLine("Cast");
            foreach (var item in castResult)
            {
                Console.Write(item + " ");
            }


            // OfType() returns only the elements of the specified type.
            var ofTypeResult = mixedData.OfType<int>();

            Console.WriteLine("OfType<int>");
            foreach (var item in castResult)
            {
                Console.Write(item + " ");
            }


        }
    }
}
