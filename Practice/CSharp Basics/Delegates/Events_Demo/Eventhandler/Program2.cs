using ConsoleApp1.CSharp_Basics.Delegates.Events_Demo.Eventhandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Delegates.Events_Demo.Eventhandler
{



    // Custom event-data class.
    // EventArgs = predefined .NET base class for event data.
    // MyEventArgs inherits from EventArgs.
    // Meaning: this class will carry data through the event.
    class MyEventArgs : EventArgs
    {

        // Property that stores the data we want to send
        // Message is of type string
        // data.Message will be string
        public string Message { get; set; }  // It creates a public property named Message that can store and return a string value, allowing event data to be passed from the event source to the event handler
        public int Age { get; set; }
        public bool IsAdmin { get; set; }

    }


    class Buttons
    {
        // Event declaration
        // EventHandler<T>
        // T = generic placeholder
        // Here T becomes MyEventArgs
        // Internally behaves roughly like:
        // delegate void EventHandler(
        // object sender,
        // MyEventArgs e
        // );
        public event EventHandler<MyEventArgs> Clicks; //The syntax internally looks likes this-> public delegate void EventHandler<TEventArgs>
                                                       //                               (object sender, TEventArgs e)
                                          // Here TEventArgs is a generic type but object is fixed. 
        public void clicker()
        {
            // Create object of MyEventArgs
            // data is NOT string
            // data is a MyEventArgs object
            MyEventArgs data = new MyEventArgs();
            // data is NOT string
            // data is a MyEventArgs object
            data.Message = "Hello";
            data.Age = 25;
            data.IsAdmin = true;
            Clicks?.Invoke(this, data); //data is of type: MyEventArgs
                                        // Here we passed all the properties related to the object 'data' to the event. 
        }
    }
    internal class Program2
    {
        public static void Run()
        {
            Buttons btns = new Buttons();

            btns.Clicks += ButtnClicked;
            btns.clicker();
        }


        // sender contains: Button object

        // e contains: MyEventArgs object
        // e = data

        // Access property using dot operator object.Property
        public static void ButtnClicked(object sender, MyEventArgs e)
        {
            Console.WriteLine("Button is clicked");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.Age);
            Console.WriteLine(e.IsAdmin);
        }
    }
}

