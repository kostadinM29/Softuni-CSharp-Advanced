using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            using (StreamWriter writer = new StreamWriter("../../../output.txt"))
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    int countLetters = CountLetters(line);
                    int countMarks = CountOfPunctuations(line);
                    writer.WriteLine($"Line {i + 1}: {lines[i]} ({countLetters})({countMarks})");

                }
            }
        }
        static int CountLetters(string line)
        {
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (char.IsLetter(currentSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }
        static int CountOfPunctuations(string line)
        {
            int counter = 0;
            char[] marks = { '-', ',', '.', '!', '?', '\'' };
            for (int i = 0; i < line.Length; i++)
            {
                char currentSymbol = line[i];
                if (marks.Contains(currentSymbol))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
