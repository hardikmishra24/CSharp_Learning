using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.ExceptionHandling
{
    internal class NestedException
    {
        public static void Run()
        {
            try
            {
                Console.WriteLine("Outer Try");

                try
                {
                    int x = 5;
                    int y = 0;

                    Console.WriteLine(x / y);
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Inner catch" + ex.Message);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Outer Catch: " + ex.Message);
            }
            //Message is a property that contains the error description. Message is a predefined property of the Exception class that stores the description of the error.
            //When the error occurs: DivideByZeroException it gets stored in: ex. Then: ex.Message contains: Attempted to divide by zero. So: Console.WriteLine(ex.Message); prints: Attempted to divide by zero.
            
        }
    }
    }


