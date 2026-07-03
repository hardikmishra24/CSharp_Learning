using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.SOLID_Principles
{
    // It states that a class should be open for extension but closed for modifications other than fixing bugs.
    // We should be able to add new functionality but cannot modify the existing codebase.
    // Can be implemented using polymorphism, inheritance, function parameters or abstract classes.

    interface Inotification
    {
        void Send();
    }

    public class Email : Inotification
    {
        public void Send()
        {
            Console.WriteLine("Email send");
        }

        public class Whatsapp : Inotification
        {
            public void Send()
            {
                Console.WriteLine("Whatsapp send");
            }
        }

        internal class Open_Closed_Principle
        {
            public static void Run()
            {
                Inotification notification = new Email();
                notification = new Whatsapp();
                // Here if we want to add new service like telegram we can add easily without modifying the code just a new class which extends the interface is required.
            }
        }
    }
}