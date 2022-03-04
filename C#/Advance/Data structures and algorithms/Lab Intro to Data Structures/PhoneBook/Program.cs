namespace PhoneBook
{
    using System;
    using System.Linq;
    using Wintellect.PowerCollections;

    class Program
    {
        static void Main()
        {
            MultiDictionary<string, string> multiDic = new MultiDictionary<string, string>(true);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] namePhone = Console.ReadLine()
                    .Split(" - ");

                string name = namePhone[0];
                string phone = namePhone[1];

                multiDic.Add(name, phone);
            }

            foreach (var kvp in multiDic.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}