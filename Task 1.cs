using System;
using System.IO;

namespace ConsoleApp10
{
    class Program
    {
        string[] dirs;
        string[] files;
        public void GetInfo(string dirN)
        {
            Console.WriteLine("Information about Directories and Files");
            Console.WriteLine("Directories :");
            dirs = Directory.GetDirectories(dirN);
            foreach(string s in dirs )
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Files :");
            files = Directory.GetFiles(dirN);
            foreach (string s in files)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
    class task1
    { 
        static void Main(string[]args)
        {
            Program program = new Program();

            program.GetInfo("C:\\");
            program.GetInfo("E:\\");

        }
    }

}
