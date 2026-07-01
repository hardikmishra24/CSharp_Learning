using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.Structural_Relationships
{
    // Aggregation is a has-a relationship where one object stores a reference to another object, but does not own it
   class Prof
   {
        public string Name { get; set; }
   }

    class Dept
    {
        private Prof professor;
        public Dept(Prof professor)
        {
            this.professor = professor;  // Here a reference is stored of the other class 
                                         // Here Department has a professor. It stores the reference in a field.
        }

        public void ShowProf()
        {
            Console.WriteLine($"Professor: {professor.Name}");
        }
    }
    internal class Aggregation
    {
        public static void Run()
        {
            Prof professor = new Prof()
            {
                Name = "Mr Mohan" 
            };

            Dept department = new Dept(professor);
            department.ShowProf();

        }
    }
}
