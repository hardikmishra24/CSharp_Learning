using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Joins
{
    public class Student
    {
      public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Department
    {
        public int StudentId { get; set; }
        public string DepartmentName { get; set; }
    }
    internal class Learn_Join
    {
        public static void Run()
        {
            List<Student> students = new List<Student>()
            {
                new Student{Id = 1, Name = "Hardik"},
                 new Student{Id = 2, Name = "Anuj"},
                  new Student{Id = 3, Name = "Arpit"},
                   new Student{Id = 4, Name = "Raj"}
            };

            List<Department> departments = new List<Department>()
            {
                new Department{StudentId = 1, DepartmentName = "IT"},
                 new Department{StudentId = 2, DepartmentName = "CSE"},
                  new Department{StudentId = 3, DepartmentName = "CIVIL"},
                   new Department{StudentId = 4, DepartmentName = "ECE"}
            };

            // Using Query syntax
            var joinresult = from s in students
                             join d in departments
                             on s.Id equals d.StudentId  //on keyword in a LINQ join specifies which fields should be matched between the two collections.
                             select new //It creates a new anonymous object that contains only the properties you want in the result.
                                        //Instead of returning the entire Student and Department objects, you're creating a new object with selected fields.
                             {
                                 s.Id,
                                 s.Name,
                                 d.DepartmentName
                             };
            foreach (var item in joinresult)
            {
                Console.WriteLine($"id:{item.Id}, Name:{item.Name}, Department:{item.DepartmentName}");
            }

            // Using method syntax
            var methodResult = students.Join(departments,
                                             s => s.Id,
                                             d => d.StudentId,
                                             (s, d) => new //It is a lambda expression called the result selector.
                                                           //"Take the matching, Student (s) and Department (d) objects, and create a new object from them."
                                             {
                                                 s.Id,
                                                 s.Name,
                                                 d.DepartmentName
                                             });
            foreach (var item in methodResult)
            { 
            Console.WriteLine($"id{item.Id}, Name{item.Name},Department {item.DepartmentName}");
            }
        }
    }
}
