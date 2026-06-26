using System;

namespace ConsoleApp1.CSharp_Basics.Contravariance
{
    //Contravariance can only be used for value input to maintain type safety.
    class Animal
    {
        public string name { get; set; }
    }

    class Lion : Animal
    {
    }

    internal class ContraVariance
    {

        // This method accepts an Animal object.
        // Since Dog, Cat, Lion etc. all inherit from Animal,
        // this one method can process every kind of animal.
        // Think of it as:  Animal Processing Machine

        static void HandleAnimal(Animal animal)
        {
            Console.WriteLine(animal.name);
        }

        public static void Run()
        {

            // Action<T> is a predefined Delegate.

            // Action<Animal> means:"Store a method that accepts ONE Animal parameter and returns NOTHING (void)."

            Action<Animal> animalHandler = HandleAnimal;



            // animalHandler
            //
            //      │
            //      ▼
            // HandleAnimal(Animal animal)
            //
            // This machine can process:
            //
            // Dog
            // Cat
            // Lion
            // Tiger
            //
            // because all of them are Animals.
            Action<Lion> lionHandler = animalHandler;

            /////////////////////////////////////////////////////////////
            // Read this line as:
            //
            // "I need a Lion-processing machine."
            //
            // C# replies:
            //
            // "Here is an Animal-processing machine."
            //
            // Is it safe?
            //
            // YES.
            //
            // Because a machine that can process EVERY Animal
            // can definitely process Dogs.
            //
            // Think of LionHandler as:
            //
            //        Lion Filter
            //             │
            //             ▼
            //     Animal Processing Machine
            //
            // The machine is STILL the Animal machine.
            //
            // dogHandler simply restricts callers so that
            // ONLY Lions can be passed through this reference.

            Lion lion = new Lion()
            {
                name = "Simba"
            };

            lionHandler(lion);
            //These are NOT allowed:LionHandler(new Cat()); LionHandler(new Dog())
        }
    }
}

/*without contravariance
 * 
 * using System;

class Animal
{
    public string Name { get; set; }
}

class Dog : Animal
{
}

class Cat : Animal
{
}

class Lion : Animal
{
}

class Program
{
    /////////////////////////////////////////////////////////////
    // PROBLEM:
    //
    // Suppose C# did NOT support Contravariance.
    //
    // Then we CANNOT reuse one Animal handler
    // for Dog, Cat, Lion, etc.
    //
    // Instead, we must create a separate method
    // for every animal type.
    //
    // As new animals are added,
    // we keep writing more and more methods.
    /////////////////////////////////////////////////////////////


    // Handles ONLY Dogs
    static void HandleDog(Dog dog)
    {
        Console.WriteLine($"Handling Dog : {dog.Name}");
    }

    // Handles ONLY Cats
    static void HandleCat(Cat cat)
    {
        Console.WriteLine($"Handling Cat : {cat.Name}");
    }

    // Handles ONLY Lions
    static void HandleLion(Lion lion)
    {
        Console.WriteLine($"Handling Lion : {lion.Name}");
    }


    /////////////////////////////////////////////////////////////
    // Imagine tomorrow new animals are added.
    //
    // Then we must AGAIN write:
    //
    // static void HandleTiger(Tiger tiger)
    // {
    // }
    //
    // static void HandleElephant(Elephant elephant)
    // {
    // }
    //
    // static void HandleHorse(Horse horse)
    // {
    // }
    //
    // static void HandleMonkey(Monkey monkey)
    // {
    // }
    //
    // The code keeps growing.
    //
    // We are writing almost identical methods
    // again and again.
    //
    // This is repetitive, difficult to maintain,
    // and violates the idea of code reuse.
    /////////////////////////////////////////////////////////////


    static void Main()
    {
        Dog dog = new Dog()
        {
            Name = "Tommy"
        };

        Cat cat = new Cat()
        {
            Name = "Kitty"
        };

        Lion lion = new Lion()
        {
            Name = "Simba"
        };


        /////////////////////////////////////////////////////////////
        // Since every method is different,
        // every delegate is also different.
        /////////////////////////////////////////////////////////////

        Action<Dog> dogHandler = HandleDog;

        Action<Cat> catHandler = HandleCat;

        Action<Lion> lionHandler = HandleLion;


        /////////////////////////////////////////////////////////////
        // Every handler can process ONLY one animal type.
        /////////////////////////////////////////////////////////////

        dogHandler(dog);

        catHandler(cat);

        lionHandler(lion);


        /////////////////////////////////////////////////////////////
        // PROBLEM SUMMARY
        //
        // Dog   → HandleDog()
        // Cat   → HandleCat()
        // Lion  → HandleLion()
        // Tiger → HandleTiger()
        // Horse → HandleHorse()
        //
        // One new animal
        // =
        // One new method
        // +
        // One new delegate
        //
        // Lots of duplicate code.
        //
        // This is exactly the problem
        // Contravariance solves.
        /////////////////////////////////////////////////////////////
    }
}
 * 
 */