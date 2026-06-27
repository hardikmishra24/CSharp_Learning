using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Covariance
{       //You can use a more specific type where a more general type is expected — on output. Covariance can only be used for output 

    class Human
    {
        public string Name { get; set; }
    }
    class Employee : Human{}

    //For withour covariance
    class Student : Human{}

    internal class CoVariance
    {
        // IEnumerable<T> is an interface that represents a collection that can only be READ or ITERATED. IEnumerable<T> supports Covariance using out keyword internally.
        static void Showhuman(IEnumerable<Human> humans)
        {
            foreach(Human human in humans) 
            {
                Console.WriteLine(human.Name);
            }
        }

        //Without Covariance
        static void Showstudent(List<Student>students)
        {
            foreach(Student student in students)
            {
                Console.WriteLine($"Showstudent:{students}");
            }
        }



        public static void Run()
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee() {Name = "Hardik"},
                new Employee() {Name = "Ram"},
                new Employee() {Name = "Rohan"}
            };

            // Covariance:Treat this sequence of Employees as a sequence of Humans. And Employee IS A Human, so this conversion is safe.
            // IEnumerable<T> supports covariance (internally uses out T) because it only allows reading, not modifying the collection. 
            IEnumerable<Human> humans = Employees;// Treat the Employee collection as a read - only sequence of Human objects, allowing every Employee to be viewed and used as a Human through covariance.
            //Creates a read-only IEnumerable<Human> view over the Employees collection, allowing every Employee to be viewed and used as a Human through covariance.
            Showhuman(humans);


            //Without Covariance
            List<Student> students = new List<Student>();
            Student s = new Student();
            s.Name = "Aman";
            students.Add(s);
        }
    }
}





 