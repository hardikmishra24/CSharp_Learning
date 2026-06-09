using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Enums
{
    internal class EnumDemo
    {
            public static void Run()
            {
                Console.WriteLine(Days.Sunday);
                int day = (int)Days.Sunday;
                Console.WriteLine(day);
            }
        //Enum is a class which contain a set of integer.
        //An Integer value is assigned to every element
            enum Days
            {
                Monday,
                Tuesday,
                Wednesday,
                Thursday,
                Friday,
                Saturday = 10,
                Sunday,
            }
        }
    }

