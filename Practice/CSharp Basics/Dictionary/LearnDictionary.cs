using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Dictionary
{
    internal class LearnDictionary
    {
        // Cannot access value by index.
        // Cannot alter the values in ascending order unlike sorted arrays.
        public static void Run() {
            Dictionary<int, string> oxford = new Dictionary<int, string>();
            oxford.Add(3, "car");
            oxford.Add(8, "truck");
            oxford.Add(5, "Bus");
           
            foreach (var student in oxford) { 
            Console.WriteLine($"{student.Key} {student.Value}");
            }

        }
    } 
}
