using System;
using System.Collections.Generic;

namespace Raiding
{
    public class Program
    {
        static void Main()
        {
            List<BaseHero> raidGroup = new List<BaseHero>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n;)
            {
                string inputHeroName = Console.ReadLine();
                string inputHeroType = Console.ReadLine();

                switch (inputHeroType) 
                {
                    case "Druid":
                        Druid druid = new Druid(inputHeroName);
                        raidGroup.Add(druid);
                        i++;
                        break;
                    case "Paladin":
                        Paladin paladin = new Paladin(inputHeroName);
                        raidGroup.Add(paladin);
                        i++;
                        break;
                    case "Rogue":
                        Rogue rogue = new Rogue(inputHeroName);
                        raidGroup.Add(rogue);
                        i++;
                        break;
                    case "Warrior":
                        Warrior warrior = new Warrior(inputHeroName);
                        raidGroup.Add(warrior);
                        i++;
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                    break;
                }
            }

            int powerBoss = int.Parse(Console.ReadLine());

            int totalPower = 0;
            foreach (var item in raidGroup)
            {
                Console.WriteLine(item.CastAbility());
                totalPower += item.Power;
            }

            if (powerBoss >= totalPower)
            {
                Console.WriteLine("Defeat...");
            }
            else
            {
                Console.WriteLine("Victory!");
            }
        }
    }
}