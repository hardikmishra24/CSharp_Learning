using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Lists
{
    internal class SortListdes
    {
        public static void Run()
        {
            SortedList<int, string> descending = new SortedList<int, string>();

            descending.Add(2, "Hardik");
            descending.Add(3, "Arun");
            descending.Add(5, "Raj");
            descending.Add(7, "Rohit");

            for(int i = descending.Count - 1; i >=0; i--)
            {
                Console.WriteLine($"{descending.Keys[i]} {descending.Values[i]}" );
            }
        }
    }
}