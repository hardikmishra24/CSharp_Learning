using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Strings
{
    internal class Learn_StringBuilder
    {
        // A string is immutable means you cannot change the value once assigned.
        // If a new value is assigned then everytime a new string will be created.
        // The previous created strings cannot be used they will be cleared by garbage collector.

        // StringBuilder is a class which allows to append the values.
        // But by using a StringBuilder we can update the required values.
        // StringBuilder is mutable.

        public static void Run() { 

        StringBuilder StrBD = new StringBuilder("version_1");
        //This will clear the old value i.e. StrBD.Clear();
        StrBD.Append("version_2");

            Console.WriteLine(StrBD);


        }
    }
}
