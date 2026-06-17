using ConsoleApp1.CSharp_Basics.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Tuples
{
    internal class LearnValueTuple
    {
        //Value tuple is the value representation of tuple.
        public static void Run()
        {
            var person = (1, "Hardik", "Cat ");
            Console.WriteLine(person);

            (int, string, string) name = (2, "Raj", "Ram");
            Console.WriteLine(name.Item1);

            (int num, string firstname, string lastname) id = (2, "Rohit", "Sharma");
            Console.WriteLine($"{id.num}{id.firstname}{id.lastname}");

            // Deconstruction is the process of extracting tuple values into separate variables in a single statement.
            (int number, string fname, string lname) = (3, "Hardik", "Mishra");

            Console.WriteLine(number);
            Console.WriteLine(fname);
            Console.WriteLine(lname);
        }
    }
}
