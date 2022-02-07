namespace Match_Phone_Number_Regex
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = @"\+359([ |-])2\1[0-9]{3}\1[0-9]{4}";
            string phones = Console.ReadLine();

            var phonsMatches = Regex.Matches(phones, pattern);

            var matchedPhones = phonsMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(string.Join(", ", matchedPhones));
        }
    }
}
