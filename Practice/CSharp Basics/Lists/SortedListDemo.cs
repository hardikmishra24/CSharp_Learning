using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Lists
{
    internal class SortedListDemo
    { 
        public static void Run()
        {
            SortedList <int, string> students = new SortedList<int, string>(); // This is a generic sorted List.
            // SortedList students = new SortedList();
            // the above is non generic sorted list. Here the keys and values are stored in 'object' data types and return an ICollection type.


            students.Add(3, "Rahul");
            students.Add(1, "Hardik");
            students.Add(2, "Aman");

            for (int i = 0; i < students.Count; i++)
            {
                // Console.WriteLine($"{students.GetKey(i)} {students.GetByIndex(i)}");    // This is used for non generic sortedlist as indexing do not work for ICollection type so Get methods are used.
                Console.WriteLine($"{students.Keys[i]} {students.Values[i]}");
            }
        }
    }
}
