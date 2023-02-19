namespace PersonsInfo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            // Sort Persons by Name and Age
            /*
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            persons.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));

            */

            
            // Salary Increase
            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(
                    cmdArgs[0], 
                    cmdArgs[1], 
                    int.Parse(cmdArgs[2]), 
                    decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }

            /*
            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
            */

            //First and Reserve Team
            Team team = new Team("SoftUni");

            foreach (var person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team.ToString());
        }
    }
}