using System;
using System.Data.Common;

namespace ConsoleApp1.CSharp_Basics.LINQ.Lambda
{
    internal class Lambda_
    {

        // Creating Delegate for lambda.
        delegate int lambdadele(int f);
            
        public static void Run()
        { 
          // LAMBDA
            // Lambda Expression (parameter) => expression;
            Func<int, int> square = c => c * c;  // In any lambda expression the delegate variable only stores the lambda, example in this line square stores the lambda.
                                                 // It only stores the lambda, it does not run it. It runs when the delegate variable is called here i.e. in next line.
                                                 //Take a parameter named c, perform c *c, and automatically return the result.
            Console.WriteLine(square(7));// From here the above code runs and returns the return value to it.
         

            // Lambda Expression for multiple paramters
            Func<int, int, int> sum = (a, b) => a + b;
            Console.WriteLine(sum(5, 10));
        

      // An action delegate hello Lambda Expression for no parameters
             Action hello = () => Console.WriteLine("Hello");  // Syntax for paramterless lambda.
            hello(); // Calling the above delagte 

            // Lambda for multiple statements
            Func<int, int> squareed = x => { Console.WriteLine(x); return x * x; };
            Console.WriteLine(squareed(8)); // Calling the above Func delegat whose name is squared.


            // Lambda for delegates
            lambdadele de = e => e * e * e;
            Console.WriteLine(de(3));
        }
    }
}