using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Initializer.ObjectInitializer
{
    // Object initializer allows to assign values to the fields or properties at the time of object creation without invoking the constructor.
    
    public class Student
    {
        public int Studentid { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    
    internal class Objects
    {
        public static void Run()
        {
            Student std1 = new Student() {Studentid = 1, Name = "Anuj", Age = 20 };

            Console.WriteLine(std1.Studentid);
        }
    }
}
