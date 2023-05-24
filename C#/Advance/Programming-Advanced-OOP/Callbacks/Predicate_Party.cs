namespace Predicate_Party
{
    public class Program
    {
        static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> startsWith = name => name.StartsWith(command[2]);
            Predicate<string> endsWith = name => name.EndsWith(command[2]);
            Predicate<string> length = name => name.Length == int.Parse(command[2]);

            int index = 0;
            while (command[0] != "Party!")
            {
                string removeOrDouble = command[0];
                string criteria = command[1];

                switch (removeOrDouble)
                {
                    case "Remove":
                        switch (criteria)
                        {
                            case "StartsWith":
                                people.RemoveAll(startsWith);
                                break;
                            case "EndsWith":
                                people.RemoveAll(endsWith);
                                break;
                            case "Length":
                                people.RemoveAll(length);
                                break;
                        }
                        break;
                    case "Double":
                        switch (criteria)
                        {
                            case "StartsWith":
                                index = people.FindAll(startsWith).FindIndex(startsWith);
                                
                                if (index != -1)
                                    people.InsertRange(index, people.FindAll(startsWith));
                                break;
                            case "EndsWith":
                                index = people.FindAll(endsWith).FindIndex(endsWith);

                                if (index != -1)
                                    people.InsertRange(index, people.FindAll(endsWith));
                                break;
                            case "Length":
                                index = people.FindAll(length).FindIndex(length);

                                if (index != -1)
                                    people.InsertRange(index, people.FindAll(length));
                                break;
                        }
                        break;
                }
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (people.Count <= 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else if (people.Count != 1)
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine(string.Join(" ", people) + "is going to the party!");
            }
        }
    }
}