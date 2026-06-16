using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Queue
{
    internal class Queuedemo
    {
        public static void Run()
        {
            Queue<int> id = new Queue<int>();

            id.Enqueue(4);
            id.Enqueue(2);
            id.Enqueue(3);
            id.Enqueue(1);

            Console.WriteLine($"Dequeue value is {id.Dequeue()}");
            Console.WriteLine($"Peak value is {id.Peek()}");
            Console.WriteLine($"whether 3 is presenet {id.Contains(2)}");

            foreach(var identity in id)
            {
                Console.WriteLine(identity);
            }
        }
    }
}