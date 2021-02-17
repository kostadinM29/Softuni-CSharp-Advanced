using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                using (StreamWriter  writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    int lineCounter = 1;

                    while (line != null)
                    {

                        if (lineCounter % 2 != 0)
                        {
                            Regex pattern = new Regex("[-,.!?]");
                            line = pattern.Replace(line, "@");
                            var array = line.Split().ToArray().Reverse();

                            writer.WriteLine(string.Join(" ", array));
                        }
                        line = reader.ReadLine();
                        lineCounter++;
                    }
                }
            }
        }
    }
}
