using ConsoleApp1.CSharp_Basics.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.UpCasting
{
    class Small
    {
        public void A() {
            Console.WriteLine("Print A");
        }
    }

    class Big : Small
    {
        public void B() { }
    }

    class Bigger : Big
    {
        public void C() { }
    }
    internal class SizeProgram
    {
        public static void Run()
        {
            // Big b = new Small(); Invalid ❌


            // Small s means "I know this variable as a Small reference, so I will only allow Small members."
            Small s = new Big(); //Small s is just a reference variable(a variable that points to an object). Here reference type is small. Even though the object is bigger
                                 // Reference  =  Actual 
                                 // variable      object
                                 //  Create a Bigger object and store its address in a reference variable of type Small.
                                 // Create a Big object and store its reference in a variable of type Small.
                                 // Reference Type = Small, Actual Object Type = Big.
                                 // It means Can access only members defined in Small; cannot directly access Big-specific members


            s.A(); // ✔
                   // s.B();  ❌
                   // s.C();  ❌
                   // you cannot access the properties in the Big or Bigger class only the property which are avialable in class Small can be accessed.
        }
    }
}