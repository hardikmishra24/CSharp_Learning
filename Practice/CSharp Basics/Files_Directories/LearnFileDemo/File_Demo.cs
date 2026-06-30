using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1.CSharp_Basics.Files_Directories.LearnFileDemo
{
   // `File` is a static class used for quick file operations such as creating. deleting files without creating an object. `FileInfo` is a class that represents a specific file as an object, allowing you to access its properties like name, creation time and perform operations on that file.
   // Ise `FileInfo` instead of `File` when we need to repeatedly work with the same file or access its detailed information, whereas `File` is better for simple, one-time operations.

    internal class File_Demo
    {
        public static void Run()
        {
            // FileInfo represents a specific file.
            // Here, the object 'file' is associated with fdemo.txt.
            FileInfo file = new FileInfo( @"C:\Users\hardi\source\repos\ConsoleApp1\Practice\CSharp Basics\Files_Directories\LearnFileDemo\fdemo.txt");

            // Checks whether the file already exists.
            if (!file.Exists)
            {
                // Creates the file.
                // Create() returns a FileStream, which keeps the file open.
                // Close() immediately closes the stream so the file is no longer locked.
                file.Create().Close();


                // Writes text into the file.
                System.IO.File.WriteAllText(file.FullName, "Hello Hardik!\nWelcome to FileInfo in C#.");

                Console.WriteLine("File created successfully.");
            }
            else
            {
                Console.WriteLine("File already exists.");
            }

            Console.WriteLine();

            // Name -> Returns only the file name.
            Console.WriteLine("File Name: " + file.Name);

            // Extension -> Returns the file extension.
            Console.WriteLine("Extension: " + file.Extension);

            // FullName -> Returns the complete path of the file.
            Console.WriteLine("Full Path: " + file.FullName);

            // DirectoryName -> Returns the folder in which the file is stored.
            Console.WriteLine("Directory: " + file.DirectoryName);

            // Length -> Returns the size of the file in bytes.
            // This works only if the file exists.
            Console.WriteLine("Size: " + file.Length + " bytes");

            // CreationTime -> Returns when the file was created.
            Console.WriteLine("Created On: " + file.CreationTime);

            // LastWriteTime -> Returns the last modified date and time.
            Console.WriteLine("Last Modified: " + file.LastWriteTime);

            // IsReadOnly -> Returns or sets whether the file is read-only.
            Console.WriteLine("Is Read Only: " + file.IsReadOnly);


        }
    }
}
