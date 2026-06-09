using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.DataTypes
{
    internal class NullableType 
    {
       public static void Run()
        {
            int? x = null; // The ? represents Nullable keyword which allows to asign nullable values to primitive datatypes.
            // Also it is not required to use nullable operator ? for value type variables they can store null values directly.
            Console.WriteLine(x);

            int ? j = null;
            int i = j ?? 0; // The '??' operator is to assign a nullable type to a non-nullable type. It means that asign the value '0' to i if j = null.



            Console.WriteLine(i); 
        }
    }
}