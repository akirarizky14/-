using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OS_TASK_2
{
    class Task2
    {
        public static void Prog2()
        {
            string path = "C:\\OS";

            Console.WriteLine("Enter the name");
            string text = Console.ReadLine();

            using (var file = new StreamWriter($"{path}\\test2.txt"))
            {
                file.WriteLine(text);
                Console.WriteLine("Text is writen in the file");
            }
            using (FileStream file = File.OpenRead($"{path}\\test2.txt"))

            {
                byte[] array = new byte[file.Length];
                file.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Text from file : {textFromFile}");
            }
            Console.WriteLine("Do you want to delete the file ? y/n");
            if (Console.ReadLine().Equals("y"))
            {
                path = "C:\\OS\test2.txt";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }
    }
}
