using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Patial_Classes
{
    internal partial class PartialClass
    {

        public int Age { get; set; }

        public void PrintAge()
        {
            Console.WriteLine(Age);
        }

        partial void SamplePartialMethod()
        {
            Console.WriteLine("Partial Method implemented.");
        }

    }
}
