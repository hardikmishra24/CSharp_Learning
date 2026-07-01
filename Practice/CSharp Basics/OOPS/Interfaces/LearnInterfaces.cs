using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.CSharp_Basics.Interfaces
{
    internal class LearnInterfaces
    {
        public static void Run()
        {
            Implementation i1 = new Implementation();
            i1.Prints();
            IMyInterface i2 = new Implementation(); // Using this object we can only access the methods which are implemented from the interface in the class other declared methods are not reachable through this object declaration. 
            i2.Prints();//Allowed
            //Not allowed i2.Extra_method();
        }
    }

    interface IMyInterface
    {
        void Prints();
    }

    class Implementation : IMyInterface
    {
        public void Prints()
        {
            Console.WriteLine("Interface is implemented");
        }

        public void Extra_method()
        {
            Console.WriteLine("Printed through extra method");
        }
    }
}