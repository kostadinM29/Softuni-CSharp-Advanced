using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo dirInfo = new DirectoryInfo("../../../");

            FileInfo[] info = dirInfo.GetFiles();

            foreach (var file in info)
            {
                if (!(dict.ContainsKey(file.Extension)))
                {
                    dict.Add(file.Extension, new Dictionary<string, double>());
                }
                dict[file.Extension].Add(file.Name, file.Length / 1024.00);
            }

            using (StreamWriter writer = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/report.txt"))
            {
                foreach (var name in dict.OrderByDescending(x=> x.Value.Count).ThenBy(c=>c.Key))
                {
                    writer.WriteLine(name.Key);
                    foreach (var item in name.Value.OrderByDescending(z=>z.Value))
                    {
                        writer.WriteLine($"--{item.Key} - {item.Value}kb");
                    }
                }
            }


        }
    }
}
