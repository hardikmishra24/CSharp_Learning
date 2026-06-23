using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.UpCasting
{
    //When a child class object is stored in a parent class reference variable, it is called Upcasting.
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

        static void Makeanimalspeak(Cat cat)// Without Upcasting we have to create seperate methods for every class
        {
           cat.Sound();
        }



        public static void Run()
        {
            Makeanimalspeak(new Dog()); // internally it is Animal animal = new Dog();
            Makeanimalspeak(new Cat());

            Dog dog = new Dog();// Without upcasting.
            Makeanimalspeak(dog);
        }
    }
}

