namespace Events_in_Given_Date_Range
{
    using System;
    using Wintellect.PowerCollections;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            OrderedMultiDictionary<DateTime, string> events = new OrderedMultiDictionary<DateTime, string>(true);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] Groups = Console.ReadLine().Split(" | ");
                string Name = Groups[0];
                DateTime Date = DateTime.Parse(Groups[1]);
                events.Add(Date, Name);
            }

            string[] dates = Console.ReadLine().Split(" | ");
            DateTime startDate = DateTime.Parse(dates[0]);
            DateTime endDate = DateTime.Parse(dates[1]);
            var eventsRange = events.Range(startDate, true, endDate, true);

            foreach (var key in eventsRange)
            {
                Console.WriteLine($"{key.Value} | {key.Key.ToString("dd-MMM-yyy hh:mm")}");
            }
        }
    }
}
