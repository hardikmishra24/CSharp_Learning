using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Thenby
{
    // ThenBy is used to sort on multiple fields, they are used after sorting by Orderby is done. 
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class _Thenby
    {
        public static void Run()
        {
            IList<Student> studentlist = new List<Student>()
            {
                new Student() { Id = 1, Name = "Hardik", Age = 20 },
                new Student() { Id = 2, Name = "Raj", Age = 19 },
                new Student() { Id = 3, Name = "Rachit", Age = 23 },
                new Student() { Id = 4, Name = "Akshat", Age = 22 },
                new Student() { Id = 5, Name = "Anuj", Age = 21 }
            };

            Console.WriteLine("Ascending order");
            var thenasc = studentlist.OrderBy(s => s.Id).ThenBy(s => s.Name);
            foreach(var std in studentlist)
            {
                Console.WriteLine($"{ std.Id} { std.Name}");
            }


            Console.WriteLine("Descending order");
            var thendsc = studentlist.OrderByDescending(s => s.Id).ThenBy(s =>s.Name);
            foreach( var std in thendsc)
            {
                Console.WriteLine($"{std.Id} {std.Name}");
            }
        }
    }
}
