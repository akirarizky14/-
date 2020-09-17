using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace OS_TASK_2
{
    class Task4
    {
        public static void Prog4()
        {
            string startPath = @"C:\Users\Admin\Desktop\as";
            string zipPath = @"C:\Users\Admin\Desktop\result122.zip";
            string extractPath = @"C:\Users\Admin\Desktop\as\extract";

            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);

            Console.WriteLine("Do you want to delete the file ? y/n");
            if (Console.ReadLine().Equals("y"))
            {
                startPath = "C:\\OS\result.zip";
                if (File.Exists(startPath))
                {
                    File.Delete(startPath);
                }
            }
        }

        }

    }

