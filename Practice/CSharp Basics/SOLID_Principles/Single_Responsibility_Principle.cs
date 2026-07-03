using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.SOLID_Principles
{
    // Single Responsibility Principle states that a class should have only one Responsibility and therefore it should have only reason to change the code.
    // Seperation of Concerns Principle is also followed here it suggests that the application should be separated into distinct sections where each section addresses a separate concern or set of information that affects the program.


    internal class Single_Responsibility_Principle
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string FirstName { get; set; }
            public string Email { get; set; }

            public void Save()
            {
                Logger.Log("Starting Save()");

                // Save student to database

                Logger.Log("End Save()");
            }

            public void Delete()
            {
                Logger.Log("Starting Delete()");

                // Delete student from database

                Logger.Log("End Delete()");
            }
        }

        public class Logger
        {
            public static void Log(string message)
            {
                Console.WriteLine(message);
            }
        }

        public class StudentRepository
        {
            public bool Save(Student std)
            {
                Logger.Log("Starting Save()");

                // Use EF to add or update student

                Logger.Log("Ending Save()");
                return true;
            }

            public bool Delete(Student std)
            {
                Logger.Log("Starting Delete()");

                // Use EF to delete student

                Logger.Log("Ending Delete()");
                return true;
            }

            public bool SaveCourse(Student std, Course cs)
            {
                Logger.Log("Starting SaveCourse()");

                // Save student-course relation

                Logger.Log("Ending SaveCourse()");
                return true;
            }
        }

        public class Course
        {
            public int CourseId { get; set; }
            public string Title { get; set; }
            public string Type { get; set; }

            public void Subscribe(Student std)
            {
                Logger.Log("Starting Subscribe()");

                if (Type == "online")
                {
                    // Subscribe to online course
                }
                else if (Type == "live")
                {
                    // Subscribe to live course
                }

                // Payment processing

                // Save student-course relation

                // Send confirmation email

                Logger.Log("End Subscribe()");
            }
        }
    }
}