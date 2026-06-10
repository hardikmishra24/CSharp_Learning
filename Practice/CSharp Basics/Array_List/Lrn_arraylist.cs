using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1.CSharp_Basics.Array_List
{
    internal class Lrn_arraylist
    {
        //  The ArrayList is a non-generic collection of objects whose size increases dynamically.
        //  It is same as array just we can store any type and any length of data here.

        public static void Run()
        {
            {
                ArrayList arlist = new ArrayList();
                arlist.Add(1);
                arlist.Add("Hardik");
                arlist.Add(" ");
                arlist.Add(null);


                // Another way to initialize the arraylist.
                var arlist2 = new ArrayList()
                {
                    1, "1", true, " ", null
                };


                int firstelement = (int)arlist[0];
                string secondelement = (string)arlist[1];
                arlist[2] = "Steve";

                Console.WriteLine(firstelement);
                Console.WriteLine(secondelement);


                var first_element = arlist[0];
                var second_element = arlist[1];

                Console.WriteLine(first_element);
                Console.WriteLine(second_element);

            }
        }
    }
}