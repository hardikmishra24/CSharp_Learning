using ConsoleApp1.CSharp_Basics.OOPS.UpCasting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.Files_Directories
{
    // Working with files and directories means managing files and folders by creating, updating and deleting them using C#.
    internal class Files
    {
        public static void Run()
        {
            Console.WriteLine(Directory.GetCurrentDirectory()); //Print the path of the folder from which the program is currently running.  Directory: A predefined class used to work with folders.  GetCurrentDirectory(): A predefined method that returns the current working folder.

            File.Create(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\data.txt").Close(); //Create a file and then close the file. We are here closing the file so that it can be accessed by other programs.
                                                                                                                               //If we do not close the file, the program keeps the file open, so Windows assumes the program is still using it and locks the file.

        

            File.WriteAllText(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\data.txt", "Hello"); //Writes text.

            File.WriteAllLines(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\data.txt", new string[] { "Apple", "Orange"}); //Write multiple lines.

            string text = File.ReadAllText(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\data.txt"); // Used to read the data in the file.

            File.AppendAllText(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\data.txt", "\nBanana"); // Used to append the data in the file i.e. updating the data in the file without deleting the prior data.

            File.AppendAllLines(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\data.txt", new string[] {"Banana", "Mango"}); // Used to append (add multiple) data in the file.

            File.Copy(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\data.txt", @"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\backup.txt"); // Copy the data in the file from one file to another.

            //File.Move("data.txt", "New location"); // It is used to move the location of a file to a new location(or repository).

            File.Delete(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\backup.txt"); // It is used to delete the content inside a file.

            bool exists = File.Exists(@"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\data.txt"); // Used to check if a file exists or not.

            //Console.WriteLine(text);
           // Console.WriteLine(exists);

        }
    }
}