using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.DataTypes
{

    //TypeCasting is a way by which we can change the data type of a value from one to another.
    internal class TypeCasting
    {
        public static void Run()
        {

            //Implicit TypeCasting
            int x = 100;
            long y = x;
            Console.WriteLine(y);


            //Explicit TypeCasting
            long k = 100;
            int j = (int)k;   // long -> int
            Console.WriteLine(j);

          


        }
    }
}
