using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Files_Directories
{
    internal class Directories
    {
        public static void Run()
        {
            //Console.WriteLine(Directory.GetCurrentDirectory());

            Directory.CreateDirectory(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\MyFolder"); //Create a folder.

            File.Create(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\MyFolder\InsideMyfolder.txt").Close(); //Creating a file inside the folder.

            String path = Path.Combine(
                @"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories",
                "MyFolder",
                "InsideMyfolder.txt");

            //Here the paths of folder and files are combined
            
            Console.WriteLine(path);
            //The Path class is a predefined class in the System.IO namespace that is used to work with file and folder paths.

            bool exists = Directory.Exists(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\MyFolder"); //Check if a folder exists

            string[] files = Directory.GetFiles(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\MyFolder"); //Get all files

            //Directory.Delete(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\MyFolder", true);  It Delete a folder
        }
    }
}