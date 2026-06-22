using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.UpCasting
{

    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Bark");
        }
    }
       
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
        
        


    internal class UpcastingDemo
    {
        static void Makeanimalspeak(Animal animal)
        {
            animal.Sound();
        }

        public static void Run()
        {
            Makeanimalspeak(new Dog());
            Makeanimalspeak(new Cat());
        }
    }
}

