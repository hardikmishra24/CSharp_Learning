using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Strings
{
    internal class StringToDatetime
    {
        public static void RunDatetime()
        {
            DateTime dt = new DateTime(2015, 12, 31);
            TimeSpan ts = new TimeSpan(25, 20, 55);

            Console.WriteLine(dt);
            Console.WriteLine(ts);
        }
    }
}