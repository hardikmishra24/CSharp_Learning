using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics
{
    internal class Files
    {
        public static void Run()
        {
            File.Create("data.txt");  // Create a File.

            File.WriteAllText("data.txt", "hello");
        }
    }
}