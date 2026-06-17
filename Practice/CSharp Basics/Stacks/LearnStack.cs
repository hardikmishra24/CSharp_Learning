using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Stacks
{
    internal class LearnStack

        // Stack uses Lifo concept which is last in first out.
        // A stack can be both generic or non generic.
    {
        public static void Run()
        {
            Stack<int> mystack = new Stack<int>();

            mystack.Push(1); // Used to add the numbers.
            mystack.Push(2);
            mystack.Push(3);
            mystack.Push(4);
            mystack.Push(5);

            Console.WriteLine($"number of string in it is {mystack.Count()}"); // .Count is used to tell the no.of elements in the stack
            Console.WriteLine($"The pop value is {mystack.Pop()}");//mystack.Pop(); // Used to diplay and remove the last added element
            Console.WriteLine($"The value of peek is {mystack.Peek()}"); // Used to diplay the last added element without removing it.
            Console.WriteLine($"Check whether the stack contain the value of 2 {mystack.Contains(2)}"); // Used to check whether the element exists in the stack or not. 

            int removedElement = mystack.Pop();
            Console.WriteLine(removedElement);

            foreach (var Stacks in mystack)
            {
                Console.WriteLine(Stacks);
            }
        }
    }
}