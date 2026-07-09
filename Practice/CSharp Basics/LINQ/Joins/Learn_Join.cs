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

            List<Department> dept = new List<Department>()
            {
                new Department{StudentId = 1, DepartmentName = "IT"},
                 new Department{StudentId = 2, DepartmentName = "CSE"},
                  new Department{StudentId = 3, DepartmentName = "CIVIL"},
                   new Department{StudentId = 4, DepartmentName = "ECE"},
            };
        }
    }
}
