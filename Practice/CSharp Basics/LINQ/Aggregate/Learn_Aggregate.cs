using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Aggregate
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    internal class Learn_Aggregate
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

            // Average
             var avgage = studentlist.Average(s => s.Age);
            Console.WriteLine(avgage);

            // Count
            var studentcount = studentlist.Count();
            Console.WriteLine($"NO of students {studentcount}");

            // Max
            var maxage = studentlist.Max(s => s.Age);
            Console.WriteLine(maxage);

            // Min
            var minage = studentlist.Min(s => s.Age);
            Console.WriteLine(minage);

            // Sum
            var summarks = studentlist.Sum(s => s.Age);
            Console.WriteLine(summarks);

            // Aggregate
            var aggre = studentlist.Select(s => s.Marks).Aggregate((a,b) => a+b);

            //Aggregate() is used to combine all the elements of a collection into one final value by performing an operation on each element one by one.
            /*
             Start: result = 80   (John)
            80 + 90 = 170
            170 + 70 = 240
            240 + 95 = 335
            335 + 60 = 395
           Final Result = 395
             */
        }
    }
}
