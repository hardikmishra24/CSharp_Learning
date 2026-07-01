using System;

namespace ConsoleApp1.CSharp_Basics.OOPS.Structural_Relationships
{
    // Association means two objects are connected, but neither owns the other.
    class Student
    {
        public string Name { get; set; }
    }

    class Teacher
    {
        public string Name { get; set; }
        public void Teach(Student student) //Teacher only uses the Student. It doesn't keep a reference to the student after the method ends.
        {
            Console.WriteLine($"{Name} is teaching {student.Name}");
        }
    }

    internal class Association
    {
        public static void Run()
        {
            Student student = new Student()
            {
                Name = "John"
            };
            Teacher teacher = new Teacher()
            {
                Name = "Mr. Smith"
            };

            // Teacher and Student are associated here.
            teacher.Teach(student);
        }
    }
}