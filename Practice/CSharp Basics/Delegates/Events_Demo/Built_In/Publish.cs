using ConsoleApp1.CSharp_Basics.DataTypes;
using ConsoleApp1.CSharp_Basics.Delegates.Events_Demo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates.Events_Demo.Built_In
{
    internal class Publish  // Publisher

    //Question: What are we trying to build? Answer:-> We want a class that : 1. Starts a process. 2. Detects when the process finishes. 3. Notifies anyone interested.
    
          // Publisher
        {

            // To tell subscribers process has completed.
            public event EventHandler ProcessCompleted; //EventHandler:- Built-in delegate provided by C#. Internally it expects methods like: void Method(object sender, EventArgs e).
                                                        //ProcessCompleted is the variable name for Event.
                                                        //Creates an event called ProcessCompleted that subscribers can listen to.
                                                        //two parameters which eventholder needs:- public void EventHandler(object sender, EventArgs e). Object sender Represents the object that raised the event. (EventArgs e) Contains additional data about the event. If there's no extra information to send, we use: EventArgs.Empty means: "The event occurred, but I have no extra data to send."
                                                        // Every subscriber method must have: void Method(object sender, EventArgs e)

            public void StartProcess() //A method that performs the work.
               //This method represents:
               //Start Download
               //Start Payment
               //Start Upload


            {
                Console.WriteLine("Process Started!");

                // Simulating work completion
                OnProcessCompleted(EventArgs.Empty);// EventArgs.Empty means: An empty EventArgs object. or: I have no event data to send.
            }


            // Raise the ProcessCompleted event. means trigger the event, fire the event.
            protected virtual void OnProcessCompleted(EventArgs e) // EventArgs is a predefined .NET class. It Carry data with an event.
                                                                   //It used Because Microsoft wanted a standard event pattern: void Method(object sender, EventArgs e)
                                                                   //EventArgs = type and e = variable name which represents event data which is empty in this case.

            {
                ProcessCompleted?.Invoke(this, e); // This represent. The current ProcessBusinessLogic object. The object of the current class.                
                                                   //(Who raised the event,Event Data)
                                                   //Invoke means trigger the event 
                                                   //If anyone subscribed to the ProcessCompleted event, notify them and send the current object (this) and event data (e).
            }
        }

    }
