using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.OOPS.Encapsulation.AcessModifier
{
    class Bankbalance
    {
        private double balance;

        public void deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void showbalance()
        {
            Console.WriteLine(balance);
        }

        protected void reset() 
        {
            balance = 0;
        }

        internal void Bankname(string name) 
        {
            Console.WriteLine(name);
        }
    }

    internal class Bank
    {
        public static void Run()
        {
            Bankbalance bank = new Bankbalance();

            bank.deposit(1000);
            bank.showbalance();
            //bank.reset();
           // bank.balance = 500
        }
    }
}
