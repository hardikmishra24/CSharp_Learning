using System;
using ConsoleApp1.CSharp_Basics.Delegates.Events_Demo.Built_In;

namespace ConsoleApp1.CSharp_Basics.Delegates.Events_Demo
{
    internal class Subscribe // Subscriber class (listens for events)
    {
        public static void Run()
        {
            Publish publ = new Publish(); // Create an object of the Publisher class.

            publ.ProcessCompleted += ProcessCompletedHandler; // Subscribe ProcessCompletedHandler to the ProcessCompleted event.
                                                              // This means: whenever the publisher raises the ProcessCompleted event,
                                                              // call the ProcessCompletedHandler method.
                                                              // += adds the handler to the event's invocation list.

            publ.StartProcess(); // Start the process.
                                 // When the process completes, the publisher will raise the event.
        }

        // Event handler method.
        // This method is automatically called when the ProcessCompleted event is raised.
        // sender = the object that raised the event (the Publisher object).
        // e = event data sent by the publisher (empty in this example).
        private static void ProcessCompletedHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Process Completed!");
        }
    }
}