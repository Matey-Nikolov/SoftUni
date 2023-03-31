namespace PlayersAndMonsters
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string type = Console.ReadLine();

            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "Elf":
                    Hero elf = new Elf(username, level);
                    Console.WriteLine(elf);
                break;
                case "MuseElf":
                    Hero museElf = new MuseElf(username, level);
                    Console.WriteLine(museElf);
                    break;
                case "Wizard":
                    Hero wizard = new Wizard(username, level);
                    Console.WriteLine(wizard);
                    break;
                case "DarkWizard":
                    Hero darkWizard = new DarkWizard(username, level);
                    Console.WriteLine(darkWizard);
                    break;
                case "SoulMaster":
                    Hero soulMaster = new SoulMaster(username, level);
                    Console.WriteLine(soulMaster);
                    break;
                case "Knight":
                    Hero knight = new Knight(username, level);
                    Console.WriteLine(knight);
                    break;
                case "DarkKnight":
                    Hero darkKnight = new DarkKnight(username, level);
                    Console.WriteLine(darkKnight);
                    break;
                case "BladeKnight":
                    Hero bladeKnight = new BladeKnight(username, level);
                    Console.WriteLine(bladeKnight);
                    break;
            }

        }
    }
}