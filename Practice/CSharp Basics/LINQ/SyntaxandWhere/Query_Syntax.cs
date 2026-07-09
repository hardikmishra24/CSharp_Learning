using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.SyntaxandWhere
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
            // The Where operator filters the collection based on a given criteria expression and returns a new collection. 
            var result = from s in strlist   // It means s is iterating through the whole strlist . s is known as range variable . s is temporary variable representing current element.
                                             // from s in strList means: "Take each element from strList, one at a time, and temporarily refer to it as s."                                
                         where s.Contains("tutorial")   // It filters the data and accept only those elements where tutorial is present.
                         select s;  // Here we select what should be returned here we returned the whole string.
                                    // The elements of s is then stored in var result. It is of type innumerable by default.
            
            // LINQ is a deferred type which means it will work only when it is enumerated. It means (var result) is empty until foreach loop or a mehtod is called. When a foreach loop is made then only a value is entered into it.
            // LINQ uses deferred execution, so the query is not executed when it is defined.
            // It executes only when the results are enumerated, such as by a foreach loop. Enumerated means: "The program starts asking the query for its results, one item at a time."
            // or by methods like ToList(), ToArray(), Count(), First(), etc.



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
