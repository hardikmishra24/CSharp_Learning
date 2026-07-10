using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Contain
{
    internal class Learn_Contains
    {
        public static void Run()
        {
            IList<int> intlist = new List<int>() {1, 2, 3, 4, 5 };

            bool result = intlist.Contains(1);
            Console.WriteLine(result);
        }
    }
}





