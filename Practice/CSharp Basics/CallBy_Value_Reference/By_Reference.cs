using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.CallBy_Value_Reference
{
    internal class By_Reference
        // Reference type variables do not store the values directly instead it stores the reference of the location where the value is stored.
    {
        public static void Run()
        {
            Student student1 = new Student();

            student1.StudentName = "Bill";

            ChangeReferenceType(student1);

            Console.WriteLine(student1.StudentName);
        }

        public static void ChangeReferenceType(Student student2)
        {
            student2.StudentName = "Steve";
        }
    }

         class Student
         {
        public string StudentName { get; set; }
         }
}

    
