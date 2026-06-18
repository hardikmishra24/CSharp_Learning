using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LearnDelegates
{
    // A delegate is a type safe function pointer. That is it holds a reference(Pointer) to a function.
    // A delegate must contain the same data-type and return-type similar to that of a function.
    // It is similar to a class, we can create the object of a delegate.
    // In the constructor we, put the function name.
    // Syntax is similar to function declaration just use the delegate keyword.



    public delegate void TestDelegate(string Message);
    internal class Delegates_Demo
    {
        public static void Run()
        {
            TestDelegate del = new TestDelegate(Test);
            del("Hello from delegates");
        }
       
        
        public static void Test(string name)
           
        {
            Console.WriteLine(name);
           } 



        }
    }

