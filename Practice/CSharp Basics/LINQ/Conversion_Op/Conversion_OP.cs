using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Concersion_Op
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }
    }

    internal class Conversion_OP
    {
        public static void Run()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){ Id = 1, Name = "John",  Age = 18, Marks = 80},
                new Student(){ Id = 2, Name = "Mary",  Age = 20, Marks = 90},
                new Student(){ Id = 3, Name = "David", Age = 19, Marks = 70},
                new Student(){ Id = 4, Name = "Sara",  Age = 21, Marks = 95},
                new Student(){ Id = 5, Name = "Tom",   Age = 18, Marks = 60}
            };
            // ToList() converts the collection into a List.
            var listResult = studentList.ToList();
            foreach (var student in listResult)
            {
                Console.WriteLine(student.Name);
            }


            // ToArray() converts the collection into an Array.
            var arrayResult = studentList.ToArray();
            Console.WriteLine("ToArray");
            foreach (var student in arrayResult)
            {
                Console.WriteLine(student.Name);
            }

            // ToDictionary() converts the collection into a Dictionary using a unique key.
            var dictionaryResult = studentList.ToDictionary(s => s.Id);
            Console.WriteLine("ToDictionary");
            foreach (var student in dictionaryResult)
            {
                Console.WriteLine($"Key : {student.Key}, Value : {student.Value.Name}");
            }
            Console.WriteLine();

            // AsEnumerable() treats the collection as IEnumerable.
            var enumerableResult = studentList.AsEnumerable();

            Console.WriteLine("AsEnumerable");

            foreach (var student in enumerableResult)
            {
                Console.WriteLine(student.Name);
            }

            // AsQueryable() treats the collection as IQueryable.
            var queryableResult = studentList.AsQueryable();

            Console.WriteLine("AsQueryable");

            foreach (var student in queryableResult)
            {
                Console.WriteLine(student.Name);
            }

            Console.WriteLine();


        }


    }
}
