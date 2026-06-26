using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Covariance
{       //Covariance can only be used for output 

    class Human
    {
        public string Name { get; set; }

    }


    class Employee : Human
    {

    }


    internal class CoVariance
    {

        // IEnumerable<T> is an interface that represents
        // a collection that can only be READ or ITERATED.   // IEnumerable<T> supports Covariance using out keyword internally.
        static void Showhuman(IEnumerable<Human> humans)
        {
            foreach(Human human in humans) 
            {
                Console.WriteLine(human.Name);
            }
        }
        public static void Run()
        {
            List<Employee> Employees = new List<Employee>()
            {
                new Employee() {Name = "Hardik"},
                new Employee() {Name = "Ram"},
                new Employee() {Name = "Rohan"}
            };

            // Covariance:
            // Treat this sequence of Employees as a sequence of Humans.
            // Employee IS A Human, so this conversion is safe.
            // IEnumerable<T> supports covariance (out T) because
            // it only allows reading, not modifying the collectio

            IEnumerable<Human> humans = Employees;// Treat the Employee collection as a read - only sequence of Human objects, allowing every Employee to be viewed and used as a Human through covariance.
            Showhuman(humans);
        }


    }


}





 // PURPOSE OF COVARIANCE
            //
            // Without Covariance:
            //
            // ShowEmployees(List<Employee>)
            // ShowManagers(List<Manager>)
            // ShowStudents(List<Student>)
            //
            // One method is needed for every child class.
            //
            // With Covariance:
            //
            // ShowHuman(IEnumerable<Human>)
            //
            // One method works for every collection whose
            // objects inherit from Human.
            //
            // This reduces duplicate code and improves
            // code reusability.
        





/* Without CoVariance  
 * 
 * using System;
 * using System.Collections.Generic;
 * ...
 * This is exactly the problem
 * Covariance solves.
 * /////////////////////////////////////////////////////////////
 * }
 * }
 * 
 * 
 * /
 * /
 * Without CoVariance  *
 * 
 * using System;
using System.Collections.Generic;

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
    // Suppose C# did NOT support Covariance.
    //
    // Then one method cannot work with
    // Dog collections, Cat collections,
    // Lion collections, etc.
    //
    // We must write a separate method
    // for every collection type.
    /////////////////////////////////////////////////////////////


    // Processes ONLY Dog collections
    static void ShowDogs(List<Dog> dogs)
    {
        foreach (Dog dog in dogs)
        {
            Console.WriteLine($"Dog : {dog.Name}");
        }
    }


    // Processes ONLY Cat collections
    static void ShowCats(List<Cat> cats)
    {
        foreach (Cat cat in cats)
        {
            Console.WriteLine($"Cat : {cat.Name}");
        }
    }


    // Processes ONLY Lion collections
    static void ShowLions(List<Lion> lions)
    {
        foreach (Lion lion in lions)
        {
            Console.WriteLine($"Lion : {lion.Name}");
        }
    }



    /////////////////////////////////////////////////////////////
    // Imagine tomorrow new animals are added.
    //
    // Then again we must write:
    //
    // ShowTigers(List<Tiger>)
    //
    // ShowElephants(List<Elephant>)
    //
    // ShowHorses(List<Horse>)
    //
    // ShowMonkeys(List<Monkey>)
    //
    // Every new animal requires
    // another almost identical method.
    //
    // The only thing changing
    // is the animal type.
    //
    // This creates duplicate code.
    /////////////////////////////////////////////////////////////


    static void Main()
    {
        List<Dog> dogs = new List<Dog>()
        {
            new Dog(){ Name = "Tommy"},
            new Dog(){ Name = "Rocky"},
            new Dog(){ Name = "Max"}
        };


        List<Cat> cats = new List<Cat>()
        {
            new Cat(){ Name = "Kitty"},
            new Cat(){ Name = "Lucy"}
        };


        List<Lion> lions = new List<Lion>()
        {
            new Lion(){ Name = "Simba"}
        };


        /////////////////////////////////////////////////////////////
        // Since every method accepts
        // only one collection type,
        // we must call a different
        // method every time.
        /////////////////////////////////////////////////////////////

        ShowDogs(dogs);

        ShowCats(cats);

        ShowLions(lions);



        /////////////////////////////////////////////////////////////
        // PROBLEM SUMMARY
        //
        // Dog Collection
        //      ↓
        // ShowDogs()
        //
        // Cat Collection
        //      ↓
        // ShowCats()
        //
        // Lion Collection
        //      ↓
        // ShowLions()
        //
        // Tiger Collection
        //      ↓
        // ShowTigers()
        //
        // Every new Animal
        //
        // =
        //
        // One new collection method.
        //
        // Lots of duplicate code.
        //
        // This is exactly the problem
        // Covariance solves.
        /////////////////////////////////////////////////////////////
    }
}
 * 
 * 
 */