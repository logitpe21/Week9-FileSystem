using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\julia.voronetskaja\samples";
            string userDirectory = "wishList";

            string newDirectoryFullPath = @$"{rootDirectory}\{userDirectory}";
            Console.WriteLine(newDirectoryFullPath);

            Directory.CreateDirectory(newDirectoryFullPath);

        }
    }
}
