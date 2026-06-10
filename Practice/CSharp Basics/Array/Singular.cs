using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Array
{
    internal class Singular
    {
        public static void Run() {


            int[] arr; // Initialised array.
            string[] cities = { "jaipur", "alwar", "delhi" };

            int[] nums = { 10, 20, 30, 50 };

            nums.Max();
            nums.Min();
            nums.Sum();
            nums.Average();


            arr = new int[5] { 2, 4, 6, 8, 10 }; // In a pre declared array values can be initialised using the new keyword. 


            int[] even = { 2, 4, 6, 8, 10};

            for (int i = 0; i < even.Length; i++)
            {
                Console.WriteLine(even[i]);
            }

        }


    } 
}
    