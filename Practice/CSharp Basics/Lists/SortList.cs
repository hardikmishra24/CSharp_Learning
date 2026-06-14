using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Lists
{
    public static void Run()
 {
     SortedList students = new SortedList();

     students.Add(3, "Rahul");
     students.Add(1, "Hardik");
     students.Add(2, "Aman");

     foreach (DictionaryEntry student in students)
     {
         Console.WriteLine(student.Key + " " + student.Value);
     }
  }
}
