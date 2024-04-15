using System.Collections.Generic;
using System.Linq;
using System;

namespace FruitDrinks
{
    public class FruitDrinks
    {
        public static void Main()
        {
            string[] drinks = Console.ReadLine()
                .Split();
            string[] drinksCombo = new string[2];
            List<string[]> drinksCombos = new List<string[]>();
            Generate(0, 0, drinks, drinksCombo, drinksCombos);

            string[] toppings = Console.ReadLine()
                .Split();
            string[] toppingsCombo = new string[1];
            List<string[]> toppingsCombos = new List<string[]>();
            Generate(0, 0, toppings, toppingsCombo, toppingsCombos);

            foreach (string[] drink in drinksCombos)
            {
                foreach (string[] topping in toppingsCombos)
                {
                    Console.WriteLine($"{string.Join(", ", drink)}, {string.Join(", ", topping)}");
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
                Generate(index + 1, i, input, combo, list);
            }
        }
    }
}