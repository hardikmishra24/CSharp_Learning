using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.Structural_Relationships
{    // Composition is a relationship where one class owns another class, and the owned object cannot exist independently of the owner.
    class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started");
        }
    }

    class Vehicle
    {
        private Engine engine = new Engine();

        public void startcar()
        {
            engine.Start();
            Console.WriteLine("Car started");
        }
    }
    internal class Composition
    {
        public static void Run()
        {
            Vehicle car = new Vehicle();
            car.startcar();
        }
    }
}
