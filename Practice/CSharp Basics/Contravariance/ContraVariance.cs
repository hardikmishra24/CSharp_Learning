using ConsoleApp1.CSharp_Basics.OOPS.UpCasting;
using System;

namespace ConsoleApp1.CSharp_Basics.Contravariance
{
    //Contravariance means : you can use a more general type where a more specific type is expected. Contravariance can only be used for value input to maintain type safety.

    class Animal
    {
        public string name { get; set; }
    }

    class Lion : Animal { }
    class Dog : Animal { }
    
    class Cat : Animal { }
        internal class ContraVariance
    {
        static void HandleAnimal(Animal animal) //`HandleAnimal` is a method that takes an `Animal` object as input and returns nothing. Since Dog, Cat, Lion etc. all inherit from Animal, so all the animals can be accepted this takes an object of animal type
        {
            Console.WriteLine(animal.name);
        }


        // Without Contravariance, it Handles ONLY Cats
        static void Handlecat(Cat cat)
        {
            Console.WriteLine($"Handling Cat : {cat.name}");
        }



        public static void Run()
        {
            Action<Animal> animalHandler = HandleAnimal;
            // Action<T> is a predefined Delegate.
            // Action<Animal> means:"Store a method that accepts ONE Animal parameter and returns NOTHING (void)."
            // animalHandler ->  HandleAnimal(Animal animal).
            // This can take any animal type object because all belong to Animals.


            Action<Lion> lionHandler = animalHandler;
            // "I need a Lion-processing machine. but the C# gives an all Animal processing machine which means a more (generic machine). So this can process every animal
            // Think of LionHandler as:  Lion Filter -> Animal Processing Machine. 
            // But The machine is STILL the Animal machine. LionHandler just restricts callers so only lions can be passed through this reference.

            Lion lion = new Lion()  
            {
                name = "Simba"
            };

            lionHandler(lion);
            //These are NOT allowed:LionHandler(new Cat()); LionHandler(new Dog());  LionHandler(new Horse())



            //* Better way of representation* it means same for that of above.
            Action<Dog> dogHandler = animalHandler;
            dogHandler(new Dog() { name = "Tommy" }); //Calls the dogHandler delegate by passing a new Dog object with its Name property set to "Tommy"."




            //Object and delegate for without contravariance
            Action<Cat> catHandler = Handlecat;
            catHandler(new Cat() { name = "Leo" });
        }
    }
}

