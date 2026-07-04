using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.SOLID_Principles
{
    //A subclass should behave like its parent class so that it can be used anywhere the parent class is expected.
    public interface Ifruit
    {
        string Getcolor();
    }

    class Orange : Ifruit
    {
        public string Getcolor()
        {
            return "orange";
        }
    }

    class Apple : Ifruit
    {
        public string Getcolor()
        {
            return "red";
        }
    }
        internal class Liskov_Substitution_Principle
        {
            public static void Run()
            { 
               Ifruit fruit = new Orange();
            Console.WriteLine($"The color of orange is : {fruit.Getcolor()}");

              fruit = new Apple();
            Console.WriteLine($"The color of apple is : {fruit.Getcolor()}");
            }
        }
}
