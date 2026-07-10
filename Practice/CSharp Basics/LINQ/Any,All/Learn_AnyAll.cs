using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Any_All
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
    }
    internal class Learn_AnyAll
    {
        public static void Run()
        {
            List<Student> students = new List<Student>()
             {
                new Student() {Id = 1, Name ="Hardik", Age = 19 },
                new Student() {Id = 2, Name ="Raj", Age = 20 },
                new Student() {Id = 3, Name ="kartik", Age = 18 },
                new Student() {Id = 4, Name ="aksh", Age = 21 }
             };

            // The All operator evalutes each elements in the given collection on a specified condition and returns True if all the elements satisfy a condition.
            bool Areallstudentteens = students.All(s => s.Age > 12 && s.Age < 20); // s =>(condition). This means a foreach loop.
                                                                                   // S iterating through each Student object one by one.
             Console.WriteLine(Areallstudentteens);


            //Any checks whether any element satisfy given condition.
            bool Isanystudentteens = students.Any(s => s.Age >12 && s.Age < 20);
            Console.WriteLine(Isanystudentteens);
        }
    }
}
