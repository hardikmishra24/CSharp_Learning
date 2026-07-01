using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.Inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName()
        {
            return FirstName + LastName;
        }
    }

    class Employee : Person
    {
       public int EmpId { get; set; }
       public string CompanyName { get; set; }
    }

    internal class Inheritance
    {
        public static void Run()
        {
            Employee emp = new Employee();
            emp.FirstName = "Hardik";
            emp.LastName = "Mishra";
            emp.EmpId = 1;
            emp.CompanyName = "abc";
            Console.WriteLine(emp.GetFullName());
            Console.WriteLine(emp.EmpId);
            Console.WriteLine(emp.CompanyName);
        }
    
    }
}
