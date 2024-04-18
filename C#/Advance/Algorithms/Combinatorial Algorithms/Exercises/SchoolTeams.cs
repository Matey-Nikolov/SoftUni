using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolTeams
{
    public class SchoolTeams
    {
        public static void Main()
        {
            string[] girls = Console.ReadLine()
                .Split(", ");
            string[] girlsCombo = new string[3];
            List<string[]> girlsCombos = new List<string[]>();
            Generate(0, 0, girls, girlsCombo, girlsCombos);

            string[] boys = Console.ReadLine()
                .Split(", ");
            string[] boysCombo = new string[2];
            List<string[]> boysCombos = new List<string[]>();
            Generate(0, 0, boys, boysCombo, boysCombos);

            foreach (string[] girl in girlsCombos)
            {
                foreach (string[] boy in boysCombos)
                {
                    Console.WriteLine($"{string.Join(", ", girl)}, {string.Join(", ", boy)}");
                }
            }
        }

        private static void Generate(int index, int start, string[] input, string[] combo, List<string[]> list)
        {
            if (index == combo.Length)
            {
                list.Add((string[])combo.Clone());
                return;
            }

            for (int i = start; i < input.Length; i++)
            {
                combo[index] = input[i];
                Generate(index + 1, i + 1, input, combo, list);
            }
        }
    }
}