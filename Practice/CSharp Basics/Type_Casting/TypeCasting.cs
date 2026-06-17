using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Type_Casting

{

    //TypeCasting is a way by which we can change the data type of a value from one to another.
    internal class TypeCasting
    {
        public static void Run()
        {

            //Implicit TypeCasting Converts a smaller data type to a larger data type automatically. No data loss.
            int x = 100;
            long y = x;
            Console.WriteLine(y);


            //Explicit TypeCasting Converts a larger data type to a smaller data type manually using (type). Data may be lost.
            long k = 100;
            int j = (int)k;   // long -> int
            Console.WriteLine(j);

          


        }
    }
}
