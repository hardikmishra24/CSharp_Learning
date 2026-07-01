using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.Inheritance
{

    // If there are multiple levels of inheritance then the constructor of the first base class will be called and then the second base class and so on.
    class vehicle
    {
        public vehicle()
        {
            Console.WriteLine("Vehicle Constructor");
        }
    }

    class truck : vehicle
    {
        public truck()
        {
            Console.WriteLine("Truck Constructor");
        }
    }
    internal class Constructor
    {
        public static void Run()
        {
            truck volvo = new truck();
        }
    }
}
