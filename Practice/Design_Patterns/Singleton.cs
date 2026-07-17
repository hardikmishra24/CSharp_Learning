using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Design_Patterns
{
   
    sealed class myclass  //Singleton class and sealed means this class cannot be inherited by other child classes.
    {
        public static int counter = 0;
        public myclass()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public void printdetail(string message)
        {
            Console.WriteLine(message);
        }

    }
    internal class Singleton
    {
        public static void Run()
        {
            myclass obj1 = new myclass();
            obj1.printdetail("Hello from obj1");

            myclass obj2 = new myclass();
            obj2.printdetail("Hello from obj2");
        }
    }
}
