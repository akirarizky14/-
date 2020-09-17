using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace OS_TASK_2
{
    class Task3
    {
        public static void Prog3()
        {
            string path = "C:\\OS";
            var example = new Example() { hello = 123 };

            using (var file = new StreamWriter($"{path}\\test.json"))
            {
                file.WriteLine(JsonSerializer.Serialize<Example>(example));
            }
                Console.WriteLine("Do you want to delete the file ? y/n");
                if (Console.ReadLine().Equals("y"))
                {
                    path = "C:\\OS\test.json";
                    if(File.Exists(path))
                    {
                        File.Delete(path);
                    }
                }
        }
        class Example
        {
            public int hello { get; set; }
        }
    }
}
