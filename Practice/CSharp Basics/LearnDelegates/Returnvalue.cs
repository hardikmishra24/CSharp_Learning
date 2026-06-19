using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


      // Here a function returns a value i.e. int or string etc.

    internal class Returnvalue
    {
        public delegate int ReturnDelegate();


        public static void Run()
        {
        ReturnDelegate del = new ReturnDelegate(SampleMethod1);
        del += SampleMethod2;

        int returnedvalue = del();

        Console.WriteLine("The returned value is " + returnedvalue);
        }

        public static int SampleMethod1()
        {
            return 1;
        }

        public static int SampleMethod2()
        {
            return 2;
        }
    }
