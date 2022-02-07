using System;
using System.Text.RegularExpressions;

namespace Lab_Regular_Expressions
{
    class Program
    {
        static void Main()
        {
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            string names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, pattern);

            foreach (Match name in matches)
            {
                Console.WriteLine(name.Value + " ");
            }

        }
    }
}
