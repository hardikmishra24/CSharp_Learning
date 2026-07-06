using System;

namespace ConsoleApp1.CSharp_Basics.LINQ.Lambda
{
    internal class Lambda_
    {
        public static int Square(int X)
        {
            return X * X;
        }

        public static int Sum(int A, int B)
        {
            return A + B;
        }

        public static void HELLO()
        {
            Console.WriteLine("Hello");
        }

        // Multiple statement without lambdas
        public static int MULTIPLY(int y)
        {
            return 2 * y;
        }

        delegate int Operations(int k);
            

        static public int operate(int k)
        {
            return 4 * k;
        }

        // Creating Delegate for lambda.
        delegate int lambdadele(int f);
            
        public static void Run()
        {
            // Calling the normal method
           
            Console.WriteLine(Square(5));
            
            Console.WriteLine(Sum(4, 10));
            
            HELLO();
            
            Console.WriteLine(MULTIPLY(3));
            
            int result = MULTIPLY(8);
            Console.WriteLine(result);
            
            Operations op = operate; 
            
            Console.WriteLine(op(8));


            // LAMBDA
            // Lambda Expression (parameter) => expression;
            Func<int, int> square = c => c * c;  // In any lambda expression the delegate variable only stores the lambda, example in this line square stores the lambda.
                                                 // It only stores the lambda, it does not run it. It runs when the delegate variable is called here i.e. in next line
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