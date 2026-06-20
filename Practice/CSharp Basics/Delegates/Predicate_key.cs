using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates
{
    internal class Predicate_key
    //Predicate is a built-in delegate used for methods that: Take one parameter and Return a bool (true or false).
    {
        public static void Run()
        {
            Predicate<int> checkAge = CanVote;

            Console.WriteLine(checkAge(20));
            Console.WriteLine(checkAge(15));


        }

        public static bool CanVote(int age)
        {
                return age >= 18;
        }
    }
}
