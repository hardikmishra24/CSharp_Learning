using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Groupby
{
    // GroupBy: Groups similar items together based on a condition.
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Query_GroupBy
    {
        public static void Run()
        {
            IList<Student> studentlist = new List<Student>()
            {
                new Student() { Id = 1, Name = "Hardik", Age = 21 },
                new Student() { Id = 2, Name = "Raj", Age = 19 },
                new Student() { Id = 3, Name = "Rachit", Age = 22 },
                new Student() { Id = 4, Name = "Akshat", Age = 22 },
                new Student() { Id = 5, Name = "Anuj", Age = 21 }
            };

            // Query Syntax
            var result = from s in studentlist
                         group s by s.Age;

            foreach (var agegroup in result)
            {
                Console.WriteLine("Age of students " + agegroup.Key);

                foreach (var studentname in agegroup)
                {
                    Console.WriteLine("Name of students " + studentname.Name);
                }
            }

            // Method Syntax
            var groupedResult = studentlist.GroupBy(s => s.Age);

            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: " + ageGroup.Key);  //Each group has a key 

                foreach (Student s in ageGroup)  //Each group has a inner collection  
                    Console.WriteLine("Student Name: " + s.Name);
            }



            // To look up.
            //ToLookup is the same as GroupBy; the only difference is GroupBy execution is deferred, whereas ToLookup execution is immediate

            var lookupResult = studentlist.ToLookup(s => s.Age);

            foreach (var group in lookupResult)
            {
                Console.WriteLine("Age Group: " + group.Key);  //Each group has a key 

                foreach (Student s in group)  //Each group has a inner collection  
                    Console.WriteLine("Student Name: " + s.Name);
            }

        }
    }
}