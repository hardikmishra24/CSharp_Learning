using Microsoft.SqlServer.Server;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.ExceptionHandling
{

    //Here we create an exception because we want the user can only login to a single window at a moment. 
    internal class CustomException
    {
        public static void Run() 
            {
                throw new UserAlreadyLoggedInException("User already logged in "); 
            }


    public class UserAlreadyLoggedInException : Exception // Inherting UserAlreadyLoggedInException class from the pre-made Exception class, so that I can get all the functionalities from Exception class.
        {

            public UserAlreadyLoggedInException() : base() { } // Inheriting the Useralreadyloggeninexception class from the already made base class. To get all the functionalities.
        public UserAlreadyLoggedInException(string message) : base(message) //base keyword is used to invoke methods of base class.
           // This parameterized constructor is made so that i can pass custom message when an exception is made.
            {

            }

            // Base keyword is used to invoke the methods or parameters of the base class, here it is Exception class in this case. 
        }
    }
}