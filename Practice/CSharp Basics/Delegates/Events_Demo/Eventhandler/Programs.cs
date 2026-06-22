using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates.Events_Demo.Eventhandler
{


    class Button
    {

        // Event declaration
        // EventHandler is a predefined .NET delegate:
        // public delegate void EventHandler(object sender, EventArgs e)
        
        
        public event EventHandler Clicked;//This means: Any method attached to this event must accept:
                                          //an object
                                          //an EventArgs
                                          //return void
                                          //That's why the ButtonClicked method have a sender object and an EventArgs  

        public void Click()
        {

            // Raise (trigger) the event

            // Clicked = event containing subscribed methods

            // ?. = null check
            // If nobody subscribed, Clicked is null
            // Prevents NullReferenceException

            // Invoke() = execute all subscribed methods

            // this = current object that raised the event
            // Passed into the handler's 'sender' parameter

            // EventArgs.Empty = predefined empty EventArgs object
            // Used when there is no extra event data to send
            Clicked?.Invoke(this, EventArgs.Empty);

            // It is directly invoking the event, then that event invokes the function ButtonClicked. Since the function requires these parms so this and EventArgs is send.

        }
    }


    internal class Programs
    {
        public static void Run()
        {
            // Create Button object
            Button btn = new Button();


            // Subscribe handler to event
            // Means:
            // "When Clicked event happens,
            // execute ButtonClicked method
            btn.Clicked += ButtonClicked;

            // Trigger the event
            btn.Click();
        }



        // Event handler method

        // object sender
        // sender receives the object that raised the event
        // In this example it will receive 'btn'

        // EventArgs e
        //   e receives event data
        // Here it receives EventArgs.Empty
        // because no additional data is being sent

        public static void ButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked");
        }


    }
}



