using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Orderby
{
    // Orderby is used to sort the collection of elements in ascending order and add Descending to sort in descending order.

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }


    internal class Query_Orderby
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

            var OrderbyResult = from s in studentlist  // This will return the elements of Name in ascending order and save them to OrderbyResult.
                                orderby s.Name
                                select s;
            Console.WriteLine("Ascending Order");
            foreach(var std in OrderbyResult)
            {
                Console.WriteLine(std.Name);
            }


            var OrderbyDescending = from s in studentlist // This will return the elements in descending order.
                                    orderby s.Name descending
                                    select s;
            Console.WriteLine("Descending Order");
            foreach (var std in OrderbyDescending)
            {
                Console.WriteLine(std.Name);
            }
    }
    }
}