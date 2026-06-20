using System; 
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.CSharp_Basics.Events_Demo.Publisher;

namespace ConsoleApp1.CSharp_Basics.Events_Demo
{
    //An event is a mechanism that allows a class (publisher) to notify other classes (subscribers) when something happens.
    internal class Publisher
    {
        public delegate void Notify();// Create a delegate with variable named as Notify and return type void.

        public class Buisnesslogic
        {
            public event Notify ProcessCompleted; //What thing can happen that others may want to know about? In this case: Process is Completed.
                                                  //The variable which define an event is noted here as ProcessCompleted
                                                  // When the process completes, I can notify interested methods.
                                                  // A container that stores a list of methods that want notification.
            public void StartProcess() // Prints a message when the process started.
            {
                Console.WriteLine("Process started..");

                OnProcessCompleted();

            }


            //When the work finishes, who will notify everyone? Answer : A dedicated method.
            //This method does not do any business work. It only tells subscribers that the work has finished.
            protected virtual void OnProcessCompleted()
            {
                ProcessCompleted?.Invoke();    //If ProcessCompleted contains subscribers, call them. Otherwise, do nothing. OR if ProcessCompleted is not null then call delegate

            }


        }
    }
}
