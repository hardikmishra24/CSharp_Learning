using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.SyntaxandWhere
{
    internal class Method_Syntax
    {
        public static void Run()
        {
            IList<string> teen = new List<string>() // Variable type teen is of type IList<string> so it can reference any object whose class implements IList<string>
            {
                "C# tutorial", ".net tutorial", "python tutorial", "java", "Ai"
            };

            var result = teen.Where(s => s.Contains("tutorial"));  // General condition Collection.where(element =>Condition). 
            /* Here s represents one string at a time.
             * When Where() starts working it automatically does something like this
             * s = "C# tutorial" then
             * s = ".net tutorial" then
             * s = "python tutorial then
             * s = "java" and so on
             * you assign s, where assign it automatically 
             * then s.Contains() runs and checks whether the element contain tutorial or not. If it contains tutorial then return true and save in s otherwise discard it.*/
            
            foreach (var str in result)
            {
            Console.WriteLine(str);
            }
        }
    }
}
