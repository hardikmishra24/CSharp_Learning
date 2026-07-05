using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ
{
    internal class Query_Syntax
    {
        public static void Run()
        {
            List<string> strlist = new List<string>() // Here we are creating a list with 5 string characters
            {
                "C# tutorial", ".net tutorial ", "abcd", "Java", "Python"
            };

            //LINQ implementation
            var result = from s in strlist   // It means to take out elements from strlist and store them in s . s is known as range variable . s is temporary variable representing current element                                 
                         where s.Contains("tutorial")   // It filters the data and accept only those elements where tutorial is present.
                         select s;  // Here we select what should be returned here we returned the whole string.
                                    // The elements of s is then stored in var result. It is of type innumerable by default.

            //the above code internally work as 
            //foreach (string s in stringList)
            //{
            //    if (s.Contains("Tutorials"))
            //    {
            //        return s
            //    }
            //}
            foreach (var str in result) // Since result is innumerable to print it's value we use foreach loop.
            {
                Console.WriteLine(str);
            }
        }
    }
}
