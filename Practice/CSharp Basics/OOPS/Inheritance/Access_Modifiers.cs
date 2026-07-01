using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.Inheritance
{
    //The protected members of the base class can be accessible in the derived class but cannot be a part of the derived class object.
    class People
    {
        protected string Name {  get; set; }
    }

    class Student : People
    {
        public string Getname()
        { 
            return this.Name; // Valid
        }
    }
    internal class Access_Modifiers
    {
        public static void Run()
        {
            Student std = new Student();

            //std.Name;        (Not accessible)
            std.Getname();   //Valid
            
        }
    }
}
