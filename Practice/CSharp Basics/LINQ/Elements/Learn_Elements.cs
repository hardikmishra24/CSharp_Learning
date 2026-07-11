using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Elements
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    internal class Learn_Elements
    {
        public static void Run()
        {
            IList<Student> studentlist = new List<Student>()
            {
                new Student(){ Id = 1, Name = "John",  Age = 18, Marks = 80},
                new Student(){ Id = 2, Name = "Mary",  Age = 20, Marks = 90},
                new Student(){ Id = 3, Name = "David", Age = 19, Marks = 70},
                new Student(){ Id = 4, Name = "Sara",  Age = 21, Marks = 95},
                new Student(){ Id = 5, Name = "Tom",   Age = 18, Marks = 60}
            };

            var elementat = studentlist.ElementAt(2).Name;
            Console.WriteLine(elementat);

            var elementdef = studentlist.ElementAtOrDefault(3).Name;
            Console.WriteLine(elementdef);

            var first = studentlist.First().Name;
            Console.WriteLine(first);

            var firstdef = studentlist.FirstOrDefault(s => s.Age > 30);
            Console.WriteLine(firstdef); // will give blank null value in the output.

            var last = studentlist.Last().Name;
            Console.WriteLine(last);

            var lastdef = studentlist.FirstOrDefault(s => s.Age > 30);
            Console.WriteLine(lastdef); // will give blank null value in the output.

            var single = studentlist.Single(s => s.Id == 2);
            Console.WriteLine(single.Name);

            var singledef = studentlist.FirstOrDefault( s => s.Id == 3);
            Console.WriteLine(singledef.Name);
        }
    }
}
