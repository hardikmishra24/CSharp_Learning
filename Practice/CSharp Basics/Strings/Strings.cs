using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Strings
{
    
    // A string is immutable means you cannot change the value once assigned.

        internal class Strings
        {

            char[] chars = { 'h', 'e', 'l', 'l', 'o' };

            public void PrintChars()
            {
            string str = new string(chars);

                for (int i = 0; i < str.Length; i++)
                {
                    Console.WriteLine(str[i]);
                }
            }


          public static void Run()
           {

                Strings s = new Strings();
                s.PrintChars();
            }

        }
    }
