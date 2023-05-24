using System.Xml.Linq;

namespace Party_Reservation_Filter_Module
{
    public class Program
    {
        static void Main()
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, Predicate<string>> filtersModules = new Dictionary<string, Predicate<string>>();

            string[] commands = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "Print")
            {
                string addOrRemoveFilter = commands[0];
                string criteria = commands[1];
                string conditionValue = commands[2];

                string both = criteria + conditionValue;
                
                switch (addOrRemoveFilter)
                {
                    case "Add filter":
                        filtersModules.Add(both, GetPredicate(criteria, conditionValue));
                        break;
                    case "Remove filter":
                        filtersModules.Remove(both);
                        break;
                }

                commands = Console.ReadLine()
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var modules in filtersModules)
            {
                people.RemoveAll(modules.Value);
            }

            Console.WriteLine(string.Join(" ", people));
        }

        public static Predicate<string> GetPredicate(string criteria, string value)
        {
            switch (criteria)
            {
                case "Starts with":
                    return name => name.StartsWith(value);
                case "Ends with":
                    return name => name.EndsWith(value);
                case "Contains":
                    return name => name.Contains(value);
                case "Length":
                    return name => name.Length == int.Parse(value);
                default:
                    return null;
            }
        }
    }
}
