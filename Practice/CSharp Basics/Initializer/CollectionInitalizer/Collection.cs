using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Initializer.CollectionInitalizer
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }


    internal class Collection
    {
        public static void Run()
        {
            // Making the objects of the class Employee.
            var employee1 = new Employee {EmployeeId = 1, EmployeeName = "Hardik" };
            var employee2 = new Employee { EmployeeId = 2, EmployeeName = null };
            var employee3 = new Employee { EmployeeId = 3, EmployeeName = "Jogn" };

            List<Employee> empList = new List<Employee>() //Create an empty list named empList that can store references to Employee objects.   
            {
              employee1,//Using collection initializer you can add elements to a collection at the time you create it, without calling the Add() method for each element.
              employee2,
            };


            //Without using collection initializer
            empList.Add(employee3); //
            Console.WriteLine(empList.Count);
        }
    }
}
