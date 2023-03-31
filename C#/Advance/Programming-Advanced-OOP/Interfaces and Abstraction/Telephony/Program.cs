namespace Telephony
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] website = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<Smartphone> smartphones = new List<Smartphone>();
            List<StationaryPhone> stationaryPhones = new List<StationaryPhone>();

            int i = 0;

            foreach (string item in phoneNumbers)
            {
                if (item.Any(char.IsLetter))
                {
                    Console.WriteLine("Invalid number");
                }
                else if (item.Length == 10)
                {
                    for (;i < website.Length; i++)
                    {
                        if (website[i].Any(char.IsDigit))
                        {
                            Console.WriteLine("Invalid URL");
                        }
                        else
                        {
                            Smartphone smartphone = new Smartphone(website[i], item);
                            smartphones.Add(smartphone);
                            i++;
                            break;
                        }
                    }
                }
                else
                {
                    StationaryPhone stationaryPhone = new StationaryPhone(item);
                    stationaryPhones.Add(stationaryPhone);
                }
            }

            Console.Write('s');
        }
    }
}