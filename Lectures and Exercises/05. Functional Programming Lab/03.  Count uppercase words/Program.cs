using System;
using System.Linq;

namespace _03.__Count_uppercase_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Where(x => x[0] == x.ToUpper()[0]).ToArray();

            Console.WriteLine(String.Join("\n", input));
        }
    }
}
