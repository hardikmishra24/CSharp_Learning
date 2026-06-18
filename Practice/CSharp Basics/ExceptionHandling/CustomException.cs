using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.ExceptionHandling
{
    internal class CustomException
    {
        public static void Run() 
            {
                throw new UserAlreadyLoggedInException("User already logged in ");
            }


    public class UserAlreadyLoggedInException : Exception
        {

            public UserAlreadyLoggedInException() : base() { }
        public UserAlreadyLoggedInException(string message) : base(message) //base keyword is used to invoke methods of base class.
            {

            }
        }
    }
}