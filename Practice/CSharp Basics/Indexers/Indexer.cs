using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Indexers
{
    internal class Indexer
    {
        // An indexer is used when a class represents a collection of data and you want users of the class to access elements using array-like syntax.
        // Can Make Code Less Clear.           
        // Extra Code to Maintain.


        public static void Run()
        {
            Student s = new Student();

            // Calls the indexer's set block
            s[0] = "Hardik";

            // Calls the indexer's get block
            Console.WriteLine(s[0]);
        }
    }

    class Student
    {
        // Array to store student names
        private string[] names = new string[3];

        public string this[int index]
        {
            // Runs when reading: s[0]

            get
            {
                return names[index];
            }


            // Runs when assigning: s[0] = "Hardik"
            set
            {
                names[index] = value;
            }
            
        }
    }
}
