using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Partioning_OP
{
    //Partitioning operators divide a collection into two parts by either skipping or taking elements.
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    internal class partioning_op
    {
        public static void Run()
        {
            List<Student> studentlist = new List<Student>()
            {
                new Student(){ Id = 1, Name = "John",  Age = 18, Marks = 80},
                new Student(){ Id = 2, Name = "Mary",  Age = 20, Marks = 90},
                new Student(){ Id = 3, Name = "David", Age = 19, Marks = 70},
                new Student(){ Id = 4, Name = "Sara",  Age = 21, Marks = 95},
                new Student(){ Id = 5, Name = "Tom",   Age = 18, Marks = 60}
            };

            // Skip() skips the specified number of elements.
            var skipresult = studentlist.Skip(2);
            foreach (var s in skipresult) 
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();
            // SkipWhile() skips elements while the condition is true.
            var skipwhile = studentlist.SkipWhile(s => s.Age < 19);
            foreach(var s in skipwhile)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();
            // Take() returns the specified number of elements from the beginning.
            var takeresult = studentlist.Take(3); 
            foreach( var s in takeresult)
            {
                Console.WriteLine(s.Name);
            }

            Console.WriteLine();
            // TakeWhile() returns elements while the condition is true.
            var takewhile = studentlist.TakeWhile(s => s.Age < 20);
            foreach( var t in takewhile)
            {
                Console.WriteLine(t.Name);
            }
        }
    }
}
