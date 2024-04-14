using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema
{
    public class Cinema
    {
        private static List<string> names;
        private static string[] positions;
        private static bool[] locked;

        public static void Main()
        {
            names = Console.ReadLine()
                .Split(", ")
                .ToList();

            positions = new string[names.Count];
            locked = new bool[names.Count];

            // Read input
            string[] commands = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "generate")
            {
                string nameFromCommands = commands[0];
                int placeFromCommands = int.Parse(commands[1]);

                locked[placeFromCommands - 1] = true;
                positions[placeFromCommands - 1] = nameFromCommands;

                commands = Console.ReadLine()
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
            }

            Generate(0);
        }

        private static void Generate(int index)
        {
            if (index >= names.Count)
            {
                Print();
                return;
            }

            for (int i = index; i < names.Count; i++)
            {
                if (!locked[i])
                {
                    locked[i] = true;

                    Swap(index, i);
                    Generate(index + 1);
                    Swap(index, i);

                    locked[i] = false;
                }

            }
        }

        private static void Print()
        {
            int index = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < positions.Length; i++)
            {
                if (locked[i])
                {
                    sb.Append($"{positions[i]} ");
                }
                else
                {
                    sb.Append($"{names[index++]} ");
                }
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        private static void Swap(int first, int second)
        {
            (names[first], names[second]) = (names[second], names[first]);
        }
    }
}
