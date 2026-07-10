using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.select_
{
    //Select is used to pick data from each item in a collection.
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
        internal class Learn_select
        {
           public static void Run()
           {
             List<Student> students = new List<Student>()
             { 
                new Student() {Id = 1, Name ="Hardik" },
                new Student() {Id = 2, Name ="Raj" },
                new Student() {Id = 3, Name ="kartik" },
                new Student() {Id = 4, Name ="aksh" }
             };

            var selectresult = from s in students
                               select s.Name;

            foreach(var student in selectresult)
            {
                Console.WriteLine(student);
            }
           }
        }
}
