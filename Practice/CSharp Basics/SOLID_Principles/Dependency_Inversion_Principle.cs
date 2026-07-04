using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.SOLID_Principles
{
    public interface Imessage
    {
        void send();
    }

    public class Telegram : Imessage           // These are the low level classes.
    {
        public void send() 
        {
            Console.WriteLine("Email send");
        }
    }

    public class SMS : Imessage           
    {
        public void send() 
        {
            Console.WriteLine("Sms send");
        }
    }


    public class Notification      //High-level class that depends on the Imessage interface.
    {
        private Imessage service;

        public Notification(Imessage service)
        {
            this.service = service;
        }
        
        public void Notify()
        {
            service.send();
        }
    }
        internal class Dependency_Inversion_Principle
        {
          public static void Run()
          {
            Imessage tele = new Telegram();
            Notification notification1 = new Notification(tele);
            notification1.Notify();

            Imessage sms = new SMS();
            Notification notification2 = new Notification(sms);
            notification2.Notify();

          }
        }
}
