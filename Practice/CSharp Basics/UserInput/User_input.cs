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
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("Your age is " + age);
        }
    }
}