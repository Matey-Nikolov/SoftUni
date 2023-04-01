using System;
using System.Collections.Generic;

namespace Explicit_Interfaces
{
    public class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                string name = input[0];
                string country = input[1];
                int age = int.Parse(input[2]);

                IPerson citizen = new Citizen(name, country, age);
                IResident citizen1 = new Citizen(name, country, age);

                Console.WriteLine(citizen.Name);
                Console.WriteLine($"{citizen.GetName()} {citizen1.GetName()}");

                input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
