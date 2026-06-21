using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.ExceptionHandling
{
    internal class Throw_Demo
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
                    throw new Exception("You are not eligible"); //new Exception means to create an Exception object
                    //throw creates an object of any valid exception type using the new keyword.
                    // Exception is a predefined class in .NET.
                    // An exception can be raised manually by using the throw keyword this is used when we try to throw an exception.
                    // As C# here will not throw any exception by itself so we created throw.
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }
    }
}