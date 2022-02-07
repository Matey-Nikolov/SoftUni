namespace Match_Dates_Regex
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string dates = Console.ReadLine();

            var datesMatches = Regex.Matches(dates, pattern);

            foreach (Match date in datesMatches)
            {
                string day = date.Groups["day"].Value;
                string month = date.Groups["month"].Value;
                string year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }

        }
    }
}
