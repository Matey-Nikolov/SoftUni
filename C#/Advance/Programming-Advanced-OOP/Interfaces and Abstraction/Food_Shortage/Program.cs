using Birthday_Celebrations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;

namespace Food_Shortage
{
    public class Program
    {
        static void Main()
        {
            List<Citizen> citizenBuyers = new List<Citizen>();
            List<Rebel> rebelBuyers = new List<Rebel>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                string[] rebelOrCitizen = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = "";
                int age;

                if (rebelOrCitizen.Length == 4)
                {
                    name = rebelOrCitizen[0];
                    age = int.Parse(rebelOrCitizen[1]);
                    BigInteger id = BigInteger.Parse(rebelOrCitizen[2]);
                    string birthdate = rebelOrCitizen[3];

                    Citizen citizen = new Citizen(id, name, age, birthdate);
                    citizenBuyers.Add(citizen);
                }
                else if (rebelOrCitizen.Length == 3)
                {
                    name = rebelOrCitizen[0];
                    age = int.Parse(rebelOrCitizen[1]);
                    string group = rebelOrCitizen[2];

                    Rebel rebel = new Rebel(name, age, group);
                    rebelBuyers.Add(rebel);
                }
            }

            string nameBuy = Console.ReadLine();
            int totalSum = 0;

            while (nameBuy != "End")
            {
                Citizen citizen = citizenBuyers.Find(x => x.Name == nameBuy);

                if (citizen != null)
                {
                    totalSum += 10;
                    //totalSum = citizen.BuyFood();
                }

                Rebel rebel = rebelBuyers.Find(x => x.Name == nameBuy);

                if (rebel != null)
                {
                    totalSum += 5;
                    //totalSum = rebel.BuyFood();
                }

                nameBuy = Console.ReadLine();
            }

            Console.WriteLine(totalSum);
        }
    }
}