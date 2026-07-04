using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.SOLID_Principles
{
    // A class should not be forced to implement methods it doesn't need.
    // Don't create one large interface with many unrelated methods.
    // Split it into smaller, specific interfaces so classes implement only what they actually use.

    public interface Iwork
    {
        void Work();
    }

    public interface Ieat
    {
        void Eat();
    }

    public class Human : Iwork, Ieat
    {
        public void Work()
        {
            Console.WriteLine("humam working");
        }

        public void Eat() 
        {
            Console.WriteLine("human eating");
        }
    }

    public class Robot : Iwork
    {
        public void Work()
        {
            Console.WriteLine("robot working");
        }
    }
    internal class Interface_Segregation_Principle
    {
        public static void Run()
        {
            Human human = new Human();
            Robot robot = new Robot();

            human.Work();
            human.Eat();

            robot.Work();
        }
    }
}
