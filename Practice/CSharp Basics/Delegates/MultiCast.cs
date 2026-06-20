using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates
{
    // A multicast delegate is the one where we can assign more than one function to a delegate
    // There are two ways to define a multicast delegate one by using the += and the other by defining different objects.

    
    internal class MultiCast
    {
        public delegate void Sampledelegate();
        public static void Run() 
        {
            Sampledelegate del1, del2, del3, del4;

            del1 = new Sampledelegate(SampleMethod);
            del2 = new Sampledelegate(SampleMethodTwo);
            del3 = new Sampledelegate(SampleMethodThree);

            del4 = del1 + del2 + del3;
            del4();

            // Sampledelegate del = new Sampledelegate(SampleMethod)
            // del += SampleMethodTwo
            // del += SampleMethodThree

           // del3();
        }

        public static void SampleMethod()
        {
            Console.WriteLine("Sample Method One");
        }

        public static void SampleMethodTwo()
        {
            Console.WriteLine("Sample Method Two");
        }

        public static void SampleMethodThree()
        {
            Console.WriteLine("Sample Method Three");
        }
    }
}
