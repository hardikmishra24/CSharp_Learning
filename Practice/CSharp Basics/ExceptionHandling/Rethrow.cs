using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.ExceptionHandling
{
    internal class Rethrow
    {
        public static void Run()
        {
            try 
            {
                Method1();
            }
            catch(NullReferenceException ex)
            {
                Console.Write(ex.StackTrace);
            }
        }

        public static void Method1()
        {
            try
            {
                Method2();
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error reached Method1 : " + ex.Message);
                throw;
                // throw ex     Re-throws the caught exception as a new throw from the current line, causing the stack trace output to start from the current method and lose the original error location.
                // It is not used now.
            }
        }

        public static void Method2()
        {
            string str = null;
            try
            {
                Console.WriteLine(str[0]);
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error occurred in Method2 : " + ex.Message);
                throw; // It means "Keep the original exception exactly as it is and send it to my caller."
            }
        }
    }
}
