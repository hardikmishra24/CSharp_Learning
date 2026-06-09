using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Patial_Classes
{
    internal class PartialClassImpl
    {
        public static void Run()
        {
            PartialClass s1 = new PartialClass();

            s1.Name = "Hardik";
            s1.Age = 20;

            s1.PrintName();
            s1.PrintAge();
        }
    }
}