using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.ExceptionHandling
{
    internal class Try_Demo
    {
        public static void Run()
        {
            int age = int.Parse(Console.ReadLine());

            try 
            {
                if (age >= 18)
                {
                    Console.WriteLine("you are eligible to vote");

                }

                else
                {
                    throw new Exception("You are not eligible"); 
                    // Throw keyword is used to make custom made exceptions along with the new keyword.
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }
    }
}