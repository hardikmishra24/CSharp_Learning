using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.CallBy_Value_Reference
{
    internal class By_Value
    //When we use call by value then the variable will store the value itself.
    //So when we change the value ins one method, it wouldn't affect the variable in another method.
    //Call by value includes mostly primitive data types.
    {
        public static void Run()
        {
            void ChangeValue(int x)
            {
             x = 200;

             Console.WriteLine("Inside ChangeValue: " + x);
            }

            int i = 100;

            Console.WriteLine("Before Method Called: " + i);

            ChangeValue(i);

            Console.WriteLine("After Method Called: " + i);
       }
    }
}

