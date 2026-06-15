using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Strings
{
    internal class StringInterpolation
    {


        public static void Run()
        {


            string firstname = "Hardik";
            string lastname = "Mishra";
            int age = 20;

            Console.WriteLine(firstname + lastname + "your age" + age);  //Without string interpolation.


            Console.WriteLine($"hello {firstname} {lastname}");// allows to use / operators 
            Console.WriteLine($"your age {age}");
            // Without string interpolation.
           
        }
    }
    
}


