using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.Inheritance
{

    public class Baseclass
    {
        public virtual void print()
        {
            Console.WriteLine("This is a baseclass method");
        }
    }

    public class Derivedclass : Baseclass
    {
        public override void print()
        {
            base.print();                         // base keyword points to the method of the base class without base keyword the mehtod of the derived class will be called.
            Console.WriteLine("This is Baseclass");
        }
    }
    internal class BaseKey
    {
        public static void Run()
        {
            Derivedclass obj = new Derivedclass();
            obj.print();
        }
    }
}