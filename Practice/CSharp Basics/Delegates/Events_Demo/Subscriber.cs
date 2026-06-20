using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.CSharp_Basics.Events_Demo.Publisher;

namespace ConsoleApp1.CSharp_Basics.Delegates.Events_Demo
{
    internal class Subscriber
    {
        public static void Run()
        {
            Buisnesslogic b1 = new Buisnesslogic();//Create an object of the publisher class because the event belongs to the publisher.


            b1.ProcessCompleted += bl_ProcessCompleted;  //Subscribe to the event.
                                                         //This means: when ProcessCompleted happens, call bl_ProcessCompleted().
                                                         //The += operator adds the method to the event's invocation list.

            b1.StartProcess();//Start the process.
                              //When the process finishes, the publisher will raise the event.

        }

        //This method is called automatically when the publisher raises the ProcessCompleted event.
        //This method is also called the event handler because it handles the event notification.
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
