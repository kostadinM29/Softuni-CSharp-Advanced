using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string regex = @"[a-zA-Z']+";

            string[] lines = File.ReadAllLines("../../../text.txt");
            string inputWords = File.ReadAllText("../../../words.txt");
            string[] words = inputWords.Split(Environment.NewLine);

            for (int i = 0; i < lines.Length; i++)
            {
                MatchCollection line = Regex.Matches(lines[i], regex);

                foreach (Match match in line)
                {
                    string word = match.Value.ToLower();
                    if (words.Contains(word))
                    {
                        if (!(dict.ContainsKey(word)))
                        {
                            dict.Add(word, 0);
                        }
                            dict[word]++;
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("../../../expectedResult.txt"))
            {
                foreach (var word in dict.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

        }
    }
}
