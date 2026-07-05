using ConsoleApp1.CSharp_Basics.OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.CSharp_Basics.Methods
{
    internal class AnonymousType
    {
        //An anonymous type cannot initialize the value it can only read the value.
        //Values cannot be changed once initialised.
        //A anonymous type can only be initialised by using var keyword.
        public static void Run()
        {
            var students = new[]
            {
                new { Id = 1, FirstName = "James", LastName = "Bond" },
                new { Id = 2, FirstName = "Steve", LastName = "Jobs" },
                new { Id = 3, FirstName = "Bill", LastName = "Gates" }
            };
            // this will throw an error students.Id = 4 -> values cannot be changed once initialised;
            // Print first student's Id
            Console.WriteLine(students[0].Id);
            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName}");
            }
        }
    }
}