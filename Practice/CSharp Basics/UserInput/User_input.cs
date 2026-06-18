using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.UserInput
{
    internal class User_input
    {
        public static void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine()); //Converts a value into an integer and returns 0 when the input is null.

            Console.WriteLine("Enter your id: ");
            int id = int.Parse(Console.ReadLine()); //Converts a valid string into an integer and throws an exception if conversion fails.

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your id is " + id);
        }
    }
}