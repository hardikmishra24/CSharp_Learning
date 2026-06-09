using System;

namespace ConsoleApp1.CSharp_Basics.OOP
{
    internal class Classes_Obj
    {
        public static void Run()
        {
            Student s1 = new Student("Hardik");

            Console.WriteLine(s1.GetName());

            s1.SetName("Rahul");

            Console.WriteLine(s1.GetName());
        }
    }

    class Student
    {
        private string name;
        //public string Name { get; set; } 
        // it is a shorter way to implement getter and setter 

        // Constructor
        public Student(string name)
        {
            this.name = name;
        }

        // Getter
        public string GetName()
        {
            return name;
        }

        // Setter
        public void SetName(string name)
        {
            this.name = name;
        }
    }
}