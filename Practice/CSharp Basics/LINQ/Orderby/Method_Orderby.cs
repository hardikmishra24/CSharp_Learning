using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.Orderby
{
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Method_Orderby
    {
        public static void Run()
        {
            IList<employee> emplist = new List<employee>()
               {
                new employee() { Id = 1, Name = "Hardik", Age = 20 },
                new employee() { Id = 2, Name = "Raj", Age = 19 },
                new employee() { Id = 3, Name = "Rachit", Age = 23 },
                new employee() { Id = 4, Name = "Akshat", Age = 22 },
                new employee() { Id = 5, Name = "Anuj", Age = 21 }
                };

            Console.WriteLine("Ascending order");
            var empasc = emplist.OrderBy(s => s.Id);
            foreach (var emp in emplist)
            {
                Console.WriteLine(emp.Id);
            }


            Console.WriteLine("Descending order");
            var empdsc = emplist.OrderByDescending(s => s.Id);
            foreach (var emp in emplist)
            {
                Console.WriteLine(emp.Id);
            }
        }

    }
}
