using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Lists
{
    internal class LearnList
    {
        // A List is a generic collection class that stores elements in a dynamically sized array and allows elements to be added, removed, accessed, and updated using an index.
        // List a generic type as compared to arraylist which depends on boxing and unboxing to store the data.
        // So a List is faster than arraylist.

        public static void Run()
        {

            {
                List<int> number = new List<int>();
                number.Add(4);
                number.Add(5);
                number.Add(2);

            }
        }
    }
}