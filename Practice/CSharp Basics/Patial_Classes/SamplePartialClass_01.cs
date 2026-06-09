using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Patial_Classes
{
    internal partial class PartialClass

    {
        public string Name { get; set; }


        partial void SamplePartialMethod();

        //Partial functions need to be declared first and then they can be initialised or implemented with the values.
        //partial void Samplemethod(){xyz}; will throw an error.
        public void PrintName()
        {
            Console.WriteLine(Name);
            SamplePartialMethod();

        }

        
        
            
        
    }
}
