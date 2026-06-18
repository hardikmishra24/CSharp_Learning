using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.ExceptionHandling
{
    internal class LearnException
    {
        public static void Run() {
            try  // Any suspected code that may raise exceptions should be put inside a try block. During the execution, if an exception occurs, the flow of the control jumps to the first matching catch block.
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"The Square of the number is {num} * {num}");
            }

            catch //catch is a block that handles an exception when an error occurs inside the try block, preventing the program from crashing.
            {
                Console.WriteLine("Error Occured");
            }

            finally //The finally block will always be executed whether an exception raised or not.
            {
                Console.WriteLine("Re-try with a different number.");
            }
    }

    } }
