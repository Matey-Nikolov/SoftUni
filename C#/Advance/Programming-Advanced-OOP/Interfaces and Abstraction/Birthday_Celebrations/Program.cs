namespace Birthday_Celebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> birthables = new List<IBirthable>();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string nameOrModel;
            int age;
            BigInteger id;
            string birthdate;

            while (input[0] != "End")
            {
                switch(input[0]) 
                {
                    case "Citizen":
                        nameOrModel = input[1];
                        age = int.Parse(input[2]);
                        id = BigInteger.Parse(input[3]);
                        birthdate = input[4];

                        Citizen citizen = new Citizen(id, nameOrModel, age, birthdate);
                        birthables.Add(citizen);
                        break;
                    case "Pet":
                        nameOrModel = input[1];
                        birthdate = input[2];

                        Pet pet = new Pet(nameOrModel, birthdate);
                        birthables.Add(pet);
                        break;
                    case "Robot":
                        Robot robot = new Robot();
                        break;
                }

                input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            int year = int.Parse(Console.ReadLine());

            birthables = birthables.Where(x => x.Birthdate.Year == year)
                .ToList();

            foreach (var item in birthables)
            {
                Console.WriteLine($"{item.Birthdate:dd/mm/yyyy}");
            }
        }
    }
}