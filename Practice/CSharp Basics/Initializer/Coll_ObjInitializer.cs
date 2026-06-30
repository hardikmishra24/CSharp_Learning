using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Initializer
{
    // Both object and collection initialization is used here.
    public class Patient
    {
        public string Pname { get; set; }
        public int Pid { get; set; }
    }
    internal class Coll_ObjInitializer
    {
        public static void Run()
        {
            List<Patient> patientslist = new List<Patient>()
            {
                new Patient() {Pid = 1, Pname = "Aniket"},
                new Patient() {Pid = 2, Pname = "Amit"}
            };

            Console.WriteLine(patientslist.Count);
        }
    }
}

