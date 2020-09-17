using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace OS_TASK_2
{
    public class Task5
    {
        public class Example1
        {
            public int hello { get; set; }
            public Example1()
            { }

            public Example1(int age)
            {
                hello = age;
            }
        }
        public static void Prog5()
        {
            string path = "C:\\OS";
            Example1 example = new Example1() { hello = 123 };

            using (var file = new StreamWriter($"{path}\\test.xml"))
            {
                XmlSerializer x = new XmlSerializer(typeof(Example1));
                x.Serialize(file, example);
            }

            Console.WriteLine("Do you want to delete the file ? y/n");
            if (Console.ReadLine().Equals("y"))
            {
                path = "C:\\OS\test.xml";
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }

    }
}
