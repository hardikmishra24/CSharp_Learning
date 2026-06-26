using System;
using System.ComponentModel;
using System.Xml.Linq;

namespace ConsoleApp1.CSharp_Basics.OOP
{

    //Object: An object is an instance of a class that contains its own data(fields/properties) and behavior(methods). Objects are created using the new keyword and represent real entities in a program.
    // Instance of a class means a real thing created from a blueprint or class.
    //Suppose you have a blueprint for a house .The blueprint itself is not a house.It just describes how a house should look. The actual house built from that blueprint is an instance of the blueprint. The blueprint is the class and the actual house is the object.




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