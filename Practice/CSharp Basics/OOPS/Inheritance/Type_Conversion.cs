using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.Inheritance
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal Eats");
        }
    }
    public class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine("Barks");
        }
    }
    internal class Type_Conversion
    {
        public static void Run()
        {
            Dog dog = new Dog();

            Animal animal = dog;    // Upcasting: Dog -> Animal (Implicit). Here 'animal' is an Animal reference that points to the same Dog object as 'dog'.
                                    // No new object is created.

            animal.Eat();

            Dog dog2 = animal as Dog;   // Downcasting: Animal -> Dog .
                                        // Here as keyword is used to prevent exceptions if the conversion fails it returns null then dog2 will contain null. 
                                        //But Since 'animal' is actually pointing to a Dog object, the conversion succeeds.
                                        // 'dog2' is a Dog reference pointing to the same Dog object as 'dog' and 'animal'.
                                        // No new object is created during the cast
            {
                if (dog2 != null)
                { 
                    dog2.Eat();
                    dog2.Speak();
                }
            }
        }
    }
}

