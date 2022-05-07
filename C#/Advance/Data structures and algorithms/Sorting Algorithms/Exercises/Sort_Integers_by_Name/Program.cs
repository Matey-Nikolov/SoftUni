namespace Sort_Integers_by_Name
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"0", "zero"},
                {"1", "one"},
                {"2", "two"},
                {"3", "three"},
                {"4", "four"},
                {"5", "five"},
                {"6", "six"},
                {"7", "seven"},
                {"8", "eight"},
                {"9", "nine"}
            };

            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[] result = new string[numbers.Length];


            for (int i = 0; i < numbers.Length; i++)
            {
                string current = numbers[i].ToString();
                string currentNumberAsText = "";
                
                // 1111 = oneoneoneone
                foreach (var digit in current)
                {
                    currentNumberAsText += dict[digit.ToString()] + "-";
                }

               
                currentNumberAsText.Remove(currentNumberAsText.Length - 1);

                result[i] = currentNumberAsText;
            }

            result = result.OrderBy(x => x).ToArray();

            for (int i = 0; i < result.Length; i++)
            {
                string[] current = result[i].Split("-");
                string number = "";

                foreach (var item in current)
                {
                    foreach (var value in dict)
                    {
                        if (value.Value == item)
                        {
                            number += value.Key;
                        }
                    }
                }

                result[i] = number;
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}