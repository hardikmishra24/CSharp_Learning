using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1.CSharp_Basics.HashTable
{
    internal class LearnHashtable
    {
        public static void Run()
        {
            // A Hashtable is a non-generic collection that stores data as key-value pairs.
            // Output order is not gauranteed.
            // Nowadays we do not use Hashtable we use dictionary
            // TypeSafety is not peresent in Hashtable
            // It is non generic type.
            // Values are not sorted.
            // Cannot acces value by index.
            Hashtable names = new Hashtable();

            names.Add(1, "mohan");
            names.Add(2, "raj");
            names.Add("three","rohit");

            foreach(DictionaryEntry name in names)
            {
                Console.WriteLine($"{name.Key} {name.Value}");
            }
        }
    }
}